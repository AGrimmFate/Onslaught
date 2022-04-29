using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee_Attack : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public AttackHurt attackHurt;
    public GameOverStats gameOverStats;
    public float attackRate = 6f;
    public GameObject camera;
    float nextAttackTime = 0f;
    public Animator KnifeSwing;
    public Animator KnifeHit;

    void Update()
    {

        if (Time.time >= nextAttackTime)
        {
            if (attackHurt.IsInAnimation == false)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    animator.SetTrigger("MeleeAttack");
                    nextAttackTime = Time.time + 1f / attackRate;
                }
            }
        }
    }

    public void Attack()
    {
        gameOverStats.StabAtempts += 1f;
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, 10f))
        {
            EnemyHitBoxes target = hit.transform.GetComponent<EnemyHitBoxes>();
            Debug.Log(hit.transform.name);
            if (target != null)
            {
                gameOverStats.hits += 1f;
                gameOverStats.StabHit += 1f;
                KnifeHit.SetTrigger("Start");
                target.DamageChecker(1f);
            }
        }
    }

    public void StartSwingSound ()
    {
        KnifeSwing.SetTrigger("Start");
    }




}
