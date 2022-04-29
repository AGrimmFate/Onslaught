using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public Animator animator;
    public Animator animator2;

    public float maxHealth;
    float currentHealth;

    public ZombieAi zombieAi;
    public BoxCollider boxCollider;

    public GameObject HitSound;
    void Start()
    {
        FindObjectOfType<KillCounter>().MonsterAdd();
        currentHealth = maxHealth;
    }


    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        animator2.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Something has died");
        animator.SetBool("IsDead", true);
        FindObjectOfType<GameOverStats>().kills += 1f;
    }
    public void Death()
    {
        boxCollider.enabled = false;
        zombieAi.disable();
    }
    public void disappear()
    {
        FindObjectOfType<KillCounter>().MonsterDie();
        gameObject.SetActive(false);
        this.enabled = false;
    }

    public void StopMakingTheSoundM8Plz()
    {
        HitSound.SetActive(false);
    }
}
