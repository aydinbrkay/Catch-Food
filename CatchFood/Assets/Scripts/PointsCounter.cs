using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsCounter : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI pointsText;
    private string text;
    void Awake() {
        pointsText.SetText("Points: 0");
    }
    public void SetPoints(int newPoints){
        pointsText.SetText("Points: " + newPoints.ToString());
    }
}
