using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfScreenChecker : MonoBehaviour
{
    private float screenBoundaryMinY;
    private float objectHeight;
    void Awake() {
        screenBoundaryMinY = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        objectHeight = GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    void Update()
    {
        CheckIfOutOfScreenFromBottom();
    }

    private void CheckIfOutOfScreenFromBottom(){
        if(transform.position.y + objectHeight < screenBoundaryMinY){
            Destroy(gameObject);
        }
    }

}
