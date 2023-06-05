using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 6f;
    private PlayerMovementScreenAdjuster playerMovementScreenAdjuster;
    void Awake() {
        playerMovementScreenAdjuster = GetComponent<PlayerMovementScreenAdjuster>();
    }
    
    public void Move(){
        float movement = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float newXpos = playerMovementScreenAdjuster.AdjustMovement(movement);
        transform.position = new Vector3(newXpos, -4, 0);
    }
}
