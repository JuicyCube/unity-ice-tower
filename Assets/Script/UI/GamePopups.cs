using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePopups : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject gameOverPopup, pausePopup, gamePopup;
    private CameraController cameraCom;
    private PlayerController playerCom;

    // the function make the game over screen visible
    public void SetUp(int score)
    {
        gamePopup.SetActive(false);
        gameOverPopup.SetActive(true);
        scoreText.text = "Your score is: " + score.ToString();
    }

     // the function make the game pause screen visible
    public void SetUp(CameraController cameraC, PlayerController playerC)
    {
        gamePopup.SetActive(false);
        pausePopup.SetActive(true);
        cameraCom = cameraC;
        playerCom = playerC;
    }

    // the function load game scene
    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    // the function load menu scene
    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // the function continue the game
    public void Continue()
    {
        pausePopup.SetActive(false);
        gamePopup.SetActive(true);
        cameraCom.isGameStop = false;
        playerCom.isGamePause = false;
    }
}
