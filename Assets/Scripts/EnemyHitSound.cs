using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitSound : MonoBehaviour
{
    public Animator animator;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetTrigger("Hit");
        }
    }
}
