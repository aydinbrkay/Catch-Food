using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]private Player player;
    [SerializeField]private GameOverScreen gameOverScreen;
    [SerializeField]private PointsCounter pointsCounter;
    private int playerPreviousPoints = 0;
    
    void Awake() {
        Time.timeScale = 1;//after restart
    }

    void Update()
    {
        CheckIfGameOver();
        UpdatePointsCounter();
    }

    private void CheckIfGameOver(){
        if(!player.GetIsPlayerAlive()){
            Time.timeScale = 0;
            gameOverScreen.ShowGameOverScreen(playerPreviousPoints);
        }
    }

    public void Restart(){
        SceneManager.LoadScene("SampleScene");
    }

    public void UpdatePointsCounter(){
        if(IsPointsChanged()){
            int points = player.GetPoints();
            pointsCounter.SetPoints(points);
            playerPreviousPoints = points;
        }
    }
    
    private bool IsPointsChanged(){
        if(playerPreviousPoints == player.GetPoints()){
            return false;
        }
        return true;
    }
}
