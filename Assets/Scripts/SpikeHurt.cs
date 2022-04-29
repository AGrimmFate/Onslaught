using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeHurt : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo)
    {
        EnemyHitBoxes EHB = collisionInfo.transform.GetComponent<EnemyHitBoxes>();
        if (EHB != null)
        {
            EHB.DamageChecker(4);
        }
    }
}
