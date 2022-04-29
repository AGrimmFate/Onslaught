using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHurt : MonoBehaviour
{
    public bool CanHurt = false;
    public Melee_Attack melee_Attack;
    public bool IsInAnimation = false;

    public void CanHurtIsTrue ()
    {
        melee_Attack.Attack();
    }
    public void CanHurtIsFalse ()
    {
        CanHurt = false;
        IsInAnimation = false;
    }




    public void AttackBeggin ()
    {
        IsInAnimation = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
