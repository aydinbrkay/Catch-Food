using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    private float speed;

    void Awake() {
        speed = Random.Range(1.5f, 4f);//random speed value
    }

    void Update()
    {
        Move();
    }

    private void Move(){
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
