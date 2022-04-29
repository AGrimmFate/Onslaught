using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunGunBangBang : MonoBehaviour
{
    public Animator animator1;
    public Animator DryFire;
    public int AmmoInMag = 1;
    public int MaxAmmoInMag = 1;
    public float GunDamage = 0.5f;

    public GameObject Bullet;
    public GameObject GreyBullet;

    public int Ammo = 0;
    public Text AmmoAmount;

    public HealthAndDamage HAD;


    void Update()
    {
        if (Input.GetKeyDown("r") && Ammo >= MaxAmmoInMag)
        {
            animator1.SetTrigger("Reload");
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (AmmoInMag > 0)
            {
                animator1.SetTrigger("Fire");
            } else
            {
                DryFire.SetTrigger("Start");
            }
        }
        AmmoAmount.text = Ammo.ToString() + " x";





        if (AmmoInMag > 0)
        {
            Bullet.SetActive(true);
            GreyBullet.SetActive(false);
        } else
        {
            Bullet.SetActive(false);
            GreyBullet.SetActive(true);
        }

    }
    public void GiveDaBullet(int bullet)
    {
        Ammo += bullet;
    }
    public void Heal()
    {
        if (Ammo >= 5)
        {
            GiveDaBullet(-5);
            HAD.TakeDamage(-32);
        }
    }
}
