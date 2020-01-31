using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    
    public bool isGameOver = false;
    public GameObject GameOverUI;
  

    public void CheckSteps ( int stepsLeft)
    {
        if (stepsLeft <= 0)
        {
            isGameOver = true;
            GameOverUI.SetActive(true);
            Time.timeScale = 0;
        }
    }


}
