using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldKick : MonoBehaviour
{
    public Rigidbody rb;

    Vector3 moveDirection;

    public float MoveAmount = 5000000f;

    public void OnInteract()
    {
        GameObject temp = GameObject.Find("Player");

        Rigidbody PlayerTransformV3 = temp.GetComponent<Rigidbody>();

        moveDirection = rb.transform.position - PlayerTransformV3.transform.position;

        rb.AddForce(moveDirection.normalized * MoveAmount);
        
    }

    void Update()
    {
        GameObject temp = GameObject.Find("Player");

        if (Input.GetKeyDown("k"))
        {
            temp.SetActive(false);
        }
               
    }
}
