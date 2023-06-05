using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScreenAdjuster : MonoBehaviour
{
    private float screenBoundaryMinX;
    private float screenBoundaryMaxX;
    private float objectWidth;
    void Awake() {
        Camera mainCamera = Camera.main;
        screenBoundaryMinX = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        screenBoundaryMaxX = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        objectWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2;
    }

    public float AdjustMovement(float movement){
        float newMovement = Mathf.Clamp(transform.position.x + movement, screenBoundaryMinX + objectWidth, 
                                screenBoundaryMaxX - objectWidth);
        return newMovement;
    }
}
