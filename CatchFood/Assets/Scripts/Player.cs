using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int points = 0;
    private PlayerMovement playerMovement;
    private bool isAlive = true;
    void Awake() {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        Move();
    }

    private void Move(){
        playerMovement.Move();
    }

    public bool GetIsPlayerAlive(){
        return isAlive;
    }

    public int GetPoints(){
        return points;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.CompareTag("BadFood")){
            isAlive = false;
        }
        else if(other.collider.CompareTag("GoodFood")){
            GoodFood goodFood = other.gameObject.GetComponent<GoodFood>();
            points += goodFood.GetPoints();
            Destroy(other.gameObject);
        }
    }

}
