using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject NormalMusic;
    public GameObject ShopMusic;
    public GameObject MainHud;
    public GameObject ShopHud;
    public LookingAround LAround;
    bool ShopIsOpen;

    public void OnInteract()
    {
        NormalMusic.SetActive(false);
        //ShopMusic.SetActive(true);
        MainHud.SetActive(false);
        ShopHud.SetActive(true);
        EnterShop();
    }
    
    void EnterShop()
    {
        LAround.DisableCursorLock();
        LAround.enabled = false;
        ShopIsOpen = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && ShopIsOpen)
        {
            CloseShop();
        }
    }

    public void CloseShop()
    {
        LAround.enabled = true;
        NormalMusic.SetActive(true);
        //ShopMusic.SetActive(false);
        MainHud.SetActive(true);
        ShopHud.SetActive(false);
        LAround.enableCursorLock();
        ShopIsOpen = false;
    }
}
