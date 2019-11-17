﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//This script handles changing the scenes or exiting the game.
public class gameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("ZombieShooterLevel1");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();  
    }
}
