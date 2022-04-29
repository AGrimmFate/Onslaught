using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject StipStep;
    public GameObject RunStipStep;
    public AudioListener audioListener;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public LookingAround lookingAround;
    public PlayerMovement playerMovement;
    public GunGunBangBang Gun;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            

            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Gun.enabled = true;
        playerMovement.enabled = true;
        lookingAround.enableCursorLock();
        RunStipStep.SetActive(true);
        audioListener.enabled = true;
    }
    public void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Gun.enabled = false;     //
        lookingAround.DisableCursorLock();
        playerMovement.enabled = false;
        StipStep.SetActive(false);
        RunStipStep.SetActive(false);
        audioListener.enabled = false;
    }
    public void Restart ()
    {
        Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenuPaused()
    {
        GameIsPaused = false;
        Resume();
        lookingAround.DisableCursorLock();
        SceneManager.LoadScene(0);
    }


}
