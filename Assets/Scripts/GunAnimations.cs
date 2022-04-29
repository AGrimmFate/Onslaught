using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimations : MonoBehaviour
{
    public GunGunBangBang Gun;
    public Animator animator;
    public GameObject camera;
    public bool IsInAnimation = false;
    public GameOverStats gameOverStats;
    public Animator GunshotSound;
    public Animator ReloadSound;

    public GameObject impactEffect;


    public GameObject[] BulletTrails = { };


    public float range = 0.1f;
    public float range2 = 0.2f;

    void Startfire()
    {
        animator.SetBool("IsFireing", true);

        IsInAnimation = true;

        Gun.AmmoInMag -= 1;


        float Up1 = Random.Range(-range2, range2);
        float Left1 = Random.Range(-range, range);
        float Up2 = Random.Range(-range2, range2);
        float Left2 = Random.Range(-range, range);
        float Up3 = Random.Range(-range2, range2);
        float Left3 = Random.Range(-range, range);
        float Up4 = Random.Range(-range2, range2);
        float Left4 = Random.Range(-range, range);
        float Up5 = Random.Range(-range2, range2);
        float Left5 = Random.Range(-range, range);
        float Up6 = Random.Range(-range2, range2);
        float Left6 = Random.Range(-range, range);
        float Up7 = Random.Range(-range2, range2);
        float Left7 = Random.Range(-range, range);
        float Up8 = Random.Range(-range2, range2);
        float Left8 = Random.Range(-range, range);
        //float Up9 = Random.Range(-range2, range2);
        //float Left9 = Random.Range(-range, range);
        //float Up10 = Random.Range(-range2, range2);
        //float Left10 = Random.Range(-range, range);
        //float Up11 = Random.Range(-range2, range2);
        //float Left11 = Random.Range(-range, range);
        //float Up12 = Random.Range(-range2, range2);
        //float Left12 = Random.Range(-range, range);














        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up1, Left1, 0f), out hit))
        {
            EnemyHitBoxes target = hit.transform.GetComponent<EnemyHitBoxes>();
            gameOverStats.AmmoShot += 1f;
            Debug.Log(hit.transform.name);
            if (target != null)
            {
                gameOverStats.hits += 1f;
                gameOverStats.ShotsHit += 1f;
                target.DamageChecker(0.5f);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 1.35f);
        }
        RaycastHit hit2;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up2, Left2, 0f), out hit2))
        {
            EnemyHitBoxes target = hit2.transform.GetComponent<EnemyHitBoxes>();
            gameOverStats.AmmoShot += 1f;
            Debug.Log(hit2.transform.name);
            if (target != null)
            {
                gameOverStats.hits += 1f;
                gameOverStats.ShotsHit += 1f;
                target.DamageChecker(0.5f);
            }

            GameObject impactGO2 = Instantiate(impactEffect, hit2.point, Quaternion.LookRotation(hit2.normal));
            Destroy(impactGO2, 1.35f);
        }
        RaycastHit hit3;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up3, Left3, 0f), out hit3))
        {
            EnemyHitBoxes target = hit3.transform.GetComponent<EnemyHitBoxes>();
            gameOverStats.AmmoShot += 1f;
            Debug.Log(hit3.transform.name);
            if (target != null)
            {
                gameOverStats.hits += 1f;
                gameOverStats.ShotsHit += 1f;
                target.DamageChecker(0.5f);
            }

            GameObject impactGO3 = Instantiate(impactEffect, hit3.point, Quaternion.LookRotation(hit3.normal));
            Destroy(impactGO3, 1.35f);
        }
        RaycastHit hit4;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up4, Left4, 0f), out hit4))
        {
            EnemyHitBoxes target = hit4.transform.GetComponent<EnemyHitBoxes>();
            gameOverStats.AmmoShot += 1f;
            Debug.Log(hit4.transform.name);
            if (target != null)
            {
                gameOverStats.hits += 1f;
                gameOverStats.ShotsHit += 1f;
                target.DamageChecker(0.5f);
            }

            GameObject impactGO4 = Instantiate(impactEffect, hit4.point, Quaternion.LookRotation(hit4.normal));
            Destroy(impactGO4, 1.35f);
        }
        RaycastHit hit5;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up5, Left5, 0f), out hit5))
        {
            EnemyHitBoxes target = hit5.transform.GetComponent<EnemyHitBoxes>();
            gameOverStats.AmmoShot += 1f;
            Debug.Log(hit5.transform.name);
            if (target != null)
            {
                gameOverStats.hits += 1f;
                gameOverStats.ShotsHit += 1f;
                target.DamageChecker(0.5f);
            }

            GameObject impactGO5 = Instantiate(impactEffect, hit5.point, Quaternion.LookRotation(hit5.normal));
            Destroy(impactGO5, 1.35f);
        }
        RaycastHit hit6;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up6, Left6, 0f), out hit6))
        {
            EnemyHitBoxes target = hit6.transform.GetComponent<EnemyHitBoxes>();
            gameOverStats.AmmoShot += 1f;
            Debug.Log(hit6.transform.name);
            if (target != null)
            {
                gameOverStats.hits += 1f;
                gameOverStats.ShotsHit += 1f;
                target.DamageChecker(0.5f);
            }

            GameObject impactGO6 = Instantiate(impactEffect, hit6.point, Quaternion.LookRotation(hit6.normal));
            Destroy(impactGO6, 1.35f);
        }
        RaycastHit hit7;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up7, Left7, 0f), out hit7))
        {
            EnemyHitBoxes target = hit7.transform.GetComponent<EnemyHitBoxes>();
            gameOverStats.AmmoShot += 1f;
            Debug.Log(hit7.transform.name);
            if (target != null)
            {
                gameOverStats.hits += 1f;
                gameOverStats.ShotsHit += 1f;
                target.DamageChecker(0.5f);
            }

            GameObject impactGO7 = Instantiate(impactEffect, hit7.point, Quaternion.LookRotation(hit7.normal));
            Destroy(impactGO7, 1.35f);
        }
        RaycastHit hit8;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up8, Left8, 0f), out hit8))
        {
            EnemyHitBoxes target = hit8.transform.GetComponent<EnemyHitBoxes>();
            gameOverStats.AmmoShot += 1f;
            Debug.Log(hit8.transform.name);
            if (target != null)
            {
                gameOverStats.hits += 1f;
                gameOverStats.ShotsHit += 1f;
                target.DamageChecker(0.5f);
            }

            GameObject impactGO8 = Instantiate(impactEffect, hit8.point, Quaternion.LookRotation(hit8.normal));
            Destroy(impactGO8, 1.35f);
        }
        //RaycastHit hit9;
        //if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up9, Left9, 0f), out hit9))
        //{
          //  EnemyHitBoxes target = hit9.transform.GetComponent<EnemyHitBoxes>();
//            gameOverStats.AmmoShot += 1f;
  //          Debug.Log(hit9.transform.name);
    //        if (target != null)
      //      {
        //        gameOverStats.hits += 1f;
          //      gameOverStats.ShotsHit += 1f;
            //    target.DamageChecker(0.5f);
//            }
//
  //          GameObject impactGO9 = Instantiate(impactEffect, hit9.point, Quaternion.LookRotation(hit9.normal));
    //        Destroy(impactGO9, 1.35f);
      //  }
//        RaycastHit hit10;
  //      if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up10, Left10, 0f), out hit10))
    //    {
      //      EnemyHitBoxes target = hit10.transform.GetComponent<EnemyHitBoxes>();
        //    gameOverStats.AmmoShot += 1f;
          //  Debug.Log(hit10.transform.name);
            //if (target != null)
//            {
  //              gameOverStats.hits += 1f;
    //            gameOverStats.ShotsHit += 1f;
      //          target.DamageChecker(0.5f);
        //    }
        //
          //  GameObject impactGO10 = Instantiate(impactEffect, hit10.point, Quaternion.LookRotation(hit10.normal));
//            Destroy(impactGO10, 1.35f);
 //       }
  //      RaycastHit hit11;
   //     if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up11, Left11, 0f), out hit11))
     ///   {
        //    EnemyHitBoxes target = hit11.transform.GetComponent<EnemyHitBoxes>();
          //  gameOverStats.AmmoShot += 1f;
            //Debug.Log(hit11.transform.name);
//            if (target != null)
  //          {
    //            gameOverStats.hits += 1f;
      //          gameOverStats.ShotsHit += 1f;
        //        target.DamageChecker(0.5f);
          //  }
          //
            //GameObject impactGO11 = Instantiate(impactEffect, hit11.point, Quaternion.LookRotation(hit11.normal));
            //Destroy(impactGO11, 1.35f);
//        }
  //      RaycastHit hit12;
    //    if (Physics.Raycast(camera.transform.position, camera.transform.forward + new Vector3(Up12, Left12, 0f), out hit12))
      //  {
        //    EnemyHitBoxes target = hit12.transform.GetComponent<EnemyHitBoxes>();
          //  gameOverStats.AmmoShot += 1f;
            //Debug.Log(hit12.transform.name);
          //  if (target != null)
        //    {
      //          gameOverStats.hits += 1f;
    //            gameOverStats.ShotsHit += 1f;
  //              target.DamageChecker(0.5f);
//            }

            //GameObject impactGO12 = Instantiate(impactEffect, hit12.point, Quaternion.LookRotation(hit12.normal));
          //  Destroy(impactGO12, 1.35f);
        //}


    }

    public void EndFire()
    {
        animator.SetBool("IsFireing", false);
        IsInAnimation = false;
    }


    public void StartReload()
    {
        animator.SetBool("IsReloading", true);

        IsInAnimation = true;

    }
    public void EndReload()
    {
        animator.SetBool("IsReloading", false);

        Gun.Ammo -= Gun.MaxAmmoInMag;
        Gun.AmmoInMag = Gun.MaxAmmoInMag;
        IsInAnimation = false;
    }
    public void GunshotStart ()
    {
        GunshotSound.SetTrigger("Start");
    }
    public void ReloadStart()
    {
        ReloadSound.SetTrigger("Start");
    }

}