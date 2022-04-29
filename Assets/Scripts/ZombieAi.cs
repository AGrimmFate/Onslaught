using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAi : MonoBehaviour
{
    public NavMeshAgent Zombie;


    void Update()
    {
        GameObject temp = GameObject.Find("Player");
        Transform Player = temp.GetComponent<Transform>();
        Zombie.SetDestination(Player.position);
    }

    public void disable()
    {
        Zombie.enabled = false;
        this.enabled = false;
    }
}
//Testing