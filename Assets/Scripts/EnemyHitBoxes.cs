using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitBoxes : MonoBehaviour
{
    public bool IsWeakPoint;
    public float CritMultiplyer;
    public float CritAddition;
    public EnemyHealth enemyHealth;
    public void DamageChecker(float damage)
    { 
        if (IsWeakPoint)
        {
            enemyHealth.TakeDamage(damage * CritMultiplyer + CritAddition);
        } else 
        {
            enemyHealth.TakeDamage(damage);
        }
    }
}
