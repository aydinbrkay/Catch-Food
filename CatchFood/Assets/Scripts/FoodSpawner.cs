using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    private float screenBoundaryMinX;
    private float screenBoundaryMaxX;
    private float screenBoundaryMaxY;
    [SerializeField]private GameObject[] foodPrefabs;

    void Awake() {
        Camera mainCamera = Camera.main;
        screenBoundaryMinX = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        screenBoundaryMaxX = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        screenBoundaryMaxY = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

    }
    void Start()
    {
        StartCoroutine(SpawnFood());
    }

    private IEnumerator SpawnFood(){
        float randomSpawnWait;
        Vector3 randomSpawnPoint;
        GameObject randomFoodPrefab;
        float randomPrefabHalfOfObjectWidth;
        yield return new WaitForSeconds(1.5f);//wait when game starts

        while(true){
            randomSpawnWait = Random.Range(1, 2);
            randomFoodPrefab = foodPrefabs[Random.Range(0, foodPrefabs.Length)];
            randomPrefabHalfOfObjectWidth = randomFoodPrefab.GetComponent<SpriteRenderer>().bounds.size.x / 2;
            randomSpawnPoint = new Vector3(Random.Range(screenBoundaryMinX + randomPrefabHalfOfObjectWidth, 
                            screenBoundaryMaxX - randomPrefabHalfOfObjectWidth), screenBoundaryMaxY + 1, 0);
            Instantiate(randomFoodPrefab, randomSpawnPoint, new Quaternion());
            yield return new WaitForSeconds(randomSpawnWait);
        }
    }

}
