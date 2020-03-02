using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterMenu : MonoBehaviour
{
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    private int optionTotal = 3;

    private int selectedOption;

    private void Start()
    {
        selectedOption = 1;
    }












    //Menu Transitioning------------------------------
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
    public void startGame()
    {
        SceneManager.LoadScene("Haunt1");
        Debug.Log("StartGame");

    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("MainMenu");

    }
    public void creditsMenu()
    {
        SceneManager.LoadScene("CreditsMenu");
        Debug.Log("Credits");
    }
    //-----------------------------------------------
}
