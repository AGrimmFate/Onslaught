using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPiles : MonoBehaviour
{
    public GameObject BulletPile1;
    public GameObject BulletPile2;
    public GameObject BulletPile3;
    public GameObject BulletPile4;
    public GameObject BulletPile5;
    public GameObject BulletPile6;

    public GameObject BulletPile1Ammo1;
    public GameObject BulletPile2Ammo1;
    public GameObject BulletPile3Ammo1;
    public GameObject BulletPile4Ammo1;
    public GameObject BulletPile5Ammo1;
    public GameObject BulletPile6Ammo1;

    public void Level1Wave2()
    {
        BulletPile6.SetActive(false);
        BulletPile6Ammo1.SetActive(true);
    }
    public void Level1Wave3()
    {
        BulletPile1.SetActive(false);
        BulletPile2.SetActive(false);
        BulletPile3.SetActive(false);
        BulletPile4.SetActive(false);
        BulletPile1Ammo1.SetActive(true);
        BulletPile2Ammo1.SetActive(true);
        BulletPile3Ammo1.SetActive(true);
        BulletPile4Ammo1.SetActive(true);
    }
    public void Level1Wave4()
    {
        BulletPile3.SetActive(false);
        BulletPile1.SetActive(false);
        BulletPile3Ammo1.SetActive(true);
        BulletPile1Ammo1.SetActive(true);
    }
    public void Level1Wave5()
    {
        BulletPile1.SetActive(false);
        BulletPile4.SetActive(false);
        BulletPile5.SetActive(false);
        BulletPile1Ammo1.SetActive(true);
        BulletPile4Ammo1.SetActive(true);
        BulletPile5Ammo1.SetActive(true);
    }
    public void Level2Wave1()
    {

    }
}
