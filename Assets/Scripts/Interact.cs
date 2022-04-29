using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject CanInteractScreen;
    public GameObject camera;
    public LayerMask layerMask;
    public Animator giveBulletSounds;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, 10, layerMask))
        {
            CanInteractScreen.SetActive(true);

            GiveBullet giveBulletScript = hit.transform.GetComponent<GiveBullet>();
            ShieldKick ShieldKickScript = hit.transform.GetComponent<ShieldKick>();
            Shop ShopScript = hit.transform.GetComponent<Shop>();

            if (Input.GetKeyDown("e"))
            {
                if (giveBulletScript != null)
                {
                    giveBulletScript.OnInteract();
                    giveBulletSounds.SetTrigger("Start");
                } else if (ShieldKickScript != null)
                {
                    ShieldKickScript.OnInteract();
                } else if (ShopScript != null)
                {
                    ShopScript.OnInteract();
                }
            }
        } else
        {
            CanInteractScreen.SetActive(false);
        }
    }
}
