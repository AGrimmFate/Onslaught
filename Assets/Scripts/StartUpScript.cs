using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartUpScript : MonoBehaviour
{
    public Animator animator;
    public EnemyHealth enemy;

    bool canLeftClick = false;
    bool canRightClick = false;
    bool canRClick = false;
    bool canLeftShiftClick = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (canLeftClick == true && Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 1f;
            animator.SetBool("SpawnPart2", true);
        }
        if (canRightClick == true && Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1f;
            animator.SetBool("SpawnPart3", true);
            enemy.TakeDamage(99);
        }
        if (canRClick == true && Input.GetKeyDown("r"))
        {
            Time.timeScale = 1f;
            animator.SetBool("SpawnPart4", true);
        }
        if (canLeftShiftClick == true && Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


    }

    public void CanLeftClick()
    {
        canLeftClick = true;
        Time.timeScale = 0f;
    }

    public void CanRightClick ()
    {
        canRightClick = true;
        Time.timeScale = 0f;
    }

    public void CanRClick()
    {
        canRClick = true;
        Time.timeScale = 0f;
    }
    public void CanLeftShiftClick()
    {
        canLeftShiftClick = true;
        Time.timeScale = 0f;
    }

}
