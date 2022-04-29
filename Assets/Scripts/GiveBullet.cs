using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveBullet : MonoBehaviour

{
    public GunGunBangBang Gun;
    int bulletGiveAmount;
    public bool IsCheatingBulletBox;
    public GameObject Self;
    public GameObject Used;

    public GameOverStats gameOverStats;

    public void OnInteract ()
    {
        if (IsCheatingBulletBox)
        {
            gameOverStats.cheated = true;
            Gun.GiveDaBullet(1000);   //
            Self.SetActive(false);
            Used.SetActive(true);
        } else
        {
            Self.SetActive(false);
            Used.SetActive(true);
            int randomNum = Random.Range(1, 4);
            Gun.GiveDaBullet(randomNum);   //
        }
    }
}
