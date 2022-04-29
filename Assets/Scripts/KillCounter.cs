using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public int MonstersAlive;

    public bool CanSpawnEnemys = true;
    public Animator animator;
    public int Wave = 1;
    public int Level = 1;
    public Text WaveNLevelCounter;
    public HealthAndDamage healthAndDamage;


    public Animator rainbullets;
    public BulletPiles bulletPiles;




    public GameObject[] Level1Levels = {};
















    public void MonsterAdd()
    {
        MonstersAlive += 1;
    }

    public void MonsterDie()
    {
        MonstersAlive -= 1;
    }

    void Update()
    {
        WaveNLevelCounter.text = "Level " + Level.ToString() + " Wave " + Wave.ToString();

        

        if (MonstersAlive == 0 && CanSpawnEnemys == true)
        {
            if (Wave == 1)
            {
                Debug.Log("You Won!");
                CanSpawnEnemys = false;
                animator.SetTrigger("StartDownTime");
                Level1Wave2();
                bulletPiles.Level1Wave2();
            }
            if (Wave == 2)
            {
                Debug.Log("You Won!");
                CanSpawnEnemys = false;
                animator.SetTrigger("StartDownTime");
                Level1Wave3();
                bulletPiles.Level1Wave3();
            }
            if (Wave == 3)
            {
                Debug.Log("You Won!");
                CanSpawnEnemys = false;
                animator.SetTrigger("StartDownTime");
                Level1Wave4();
                bulletPiles.Level1Wave4();
            }
            if (Wave == 4)
            {
                Debug.Log("You Won!");
                CanSpawnEnemys = false;
                animator.SetTrigger("StartDownTime");
                Level1Wave5();
                bulletPiles.Level1Wave5();
            }
            if (Wave == 5)
            {
                Debug.Log("You Won!");
                CanSpawnEnemys = false;
                animator.SetTrigger("StartDownTime");
                Level1WaveBoss();
                bulletPiles.Level1Wave2();
            }
            if (Wave == 6)
            {
                healthAndDamage.TakeDamage(999);
            }
            if (Level == 2 && Wave == 1)
            {
                healthAndDamage.TakeDamage(999);
            }
        }
    }

    public void RainBulletsBaby()
    {
        rainbullets.SetTrigger("make it rain");
    }

    public void DownTimeHasEnded ()
    {
        if (Wave == 6)
        {
            Wave = 1;
            Level += 1;
        } else
        {
            Wave += 1;
        }
        CanSpawnEnemys = true;
    }

    void Level1Wave2()
    {
        Debug.Log("Loading wave 2");
        Level1Levels[1].SetActive(true);
        Level1Levels[0].SetActive(false);
    }
    void Level1Wave3()
    {
        Debug.Log("Loading wave 3");
        Level1Levels[2].SetActive(true);
        Level1Levels[1].SetActive(false);
    }
    void Level1Wave4()
    {
        Debug.Log("Loading wave 4");
        Level1Levels[3].SetActive(true);
        Level1Levels[2].SetActive(false);
    }
    void Level1Wave5()
    {
        Debug.Log("Loading wave 5");
        Level1Levels[4].SetActive(true);
        Level1Levels[3].SetActive(false);
    }
    void Level1WaveBoss()
    {
        Debug.Log("Loading wave Boss");
        Level1Levels[5].SetActive(true);
        Level1Levels[4].SetActive(false);
    }
}
