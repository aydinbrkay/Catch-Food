using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.TryGetComponent<Food>(out Food food)){
            Physics2D.IgnoreCollision(other.collider, gameObject.GetComponent<Collider2D>());
        }
    }
}
