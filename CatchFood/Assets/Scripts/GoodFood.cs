using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFood : Food
{
    private int points;

    void Awake() {
        points = Random.Range(50, 201);
    }

    public int GetPoints(){
        return points;
    } 
}
