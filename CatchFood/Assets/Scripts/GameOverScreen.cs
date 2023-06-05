using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pointsText;

    public void ShowGameOverScreen(int currentPointsText){
        pointsText.text = "Points Earned: " + currentPointsText.ToString();
        gameObject.SetActive(true);
    }

}
