using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAttack : MonoBehaviour
{
    public Animator animator;
    public bool PlayerIsInReach = false;
    public int DmgAmount;
    public Animator Hit;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("Attack", true);
            PlayerIsInReach = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("Attack", false);
            PlayerIsInReach = false;
        }
    }

    public void AttackThePlayer ()
    {
        if (PlayerIsInReach)
        {
            FindObjectOfType<HealthAndDamage>().TakeDamage(DmgAmount);
        }
    }
}