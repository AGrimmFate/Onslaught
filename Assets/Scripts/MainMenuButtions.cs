using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtions : MonoBehaviour
{
    public Animator animator;



    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Settings ()
    {
        Debug.Log("Settingsing...");
    }
    public void Quit ()
    {
        Debug.Log("Quiting...");
        Application.Quit();
    }
    public void StartAnimation ()
    {
        animator.SetTrigger("StartGame");
        Debug.Log("Starting...");
    }

}
