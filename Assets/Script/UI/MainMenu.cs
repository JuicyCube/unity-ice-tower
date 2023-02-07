using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject HowToScreen;

    // the function exit the application
    public void ExitButton()
    {
        Application.Quit();  
    }

    // the function load game scene
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    // the function open how to play popup
    public void HowToPlay()
    {
        HowToScreen.SetActive(true);
    }

    // the function close the How To Play popup
    public void CloseHowToPopup()
    {
        HowToScreen.SetActive(false);
    }
}
