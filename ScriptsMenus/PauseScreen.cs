using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public static bool pausedGame;
    public GameObject pauseMenu;

    private void Start()
    {
        pausedGame = false;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausedGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pausedGame = false;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        pausedGame = true;
    }
}
