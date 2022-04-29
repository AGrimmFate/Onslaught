using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndDamage : MonoBehaviour
{
    public int maxHealth = 16;
    public int currentHealth;

    public PlayerMovement PlayersMovement;
    public LookingAround lookingAround;
    public PauseMenu pauseMenu;

    public Bar bar;
    public HealthBar healthBar;
    public GunGunBangBang Gun;

    public GameObject GameOver;
    public GameObject Camera;

    bool Cracked = false;
    bool VaryCracked = false;
    bool Broken = false;

    public Animator animator;
    public Animator playersAnimator;

    public GameOverStats gameOverStats;



    void Start()
    {

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

   
    void Update()
    {


        if (Cracked != true && currentHealth <= 10.6)
        {
            Cracked = true;
            bar.Cracked();
        }
        




        if (VaryCracked != true && currentHealth <= 5.3)
        {
            bar.VeryCracked();
            VaryCracked = true;
        }
        if (Broken != true && currentHealth <= 0)
        {
            bar.Broken();
            Broken = true;
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 0)
        {
            die();
        }


    }







    public void TakeDamage(int damage)
    {
        if (currentHealth > 0.1)
        {
            playersAnimator.SetTrigger("Hurt");
        }

        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    
    void die()
    {
        gameOverStats.GameHasDidTheEndingThing();
        Camera.SetActive(false);
        lookingAround.Death();
        animator.SetTrigger("Die");
        PlayersMovement.Die();
        GameOver.SetActive(true);
        pauseMenu.enabled = false;
        this.enabled = false;
    }


}
