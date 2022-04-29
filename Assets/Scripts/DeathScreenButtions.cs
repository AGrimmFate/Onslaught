using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenButtions : MonoBehaviour
{
    public void Restart ()
    {
        Debug.Log("Restarting...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void MainMenu ()
    {
        Debug.Log("Main Menuing...");
        SceneManager.LoadScene(0);
    }




}
