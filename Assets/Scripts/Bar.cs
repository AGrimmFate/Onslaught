using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public GameObject MainBar;
    public GameObject CrackedBar;
    public GameObject VaryCrackedBar;
    public GameObject BrokenBar;


    void Update()
    {
    }

    public void Cracked()
    {
        Debug.Log("66% of health remaining");
        MainBar.SetActive(false);
        CrackedBar.SetActive(true);
    }
    public void VeryCracked()
    {
        Debug.Log("33% of health remaining");
        CrackedBar.SetActive(false);
        VaryCrackedBar.SetActive(true);
    }
    public void Broken()
    {
        Debug.Log("0% of health remaining");
        VaryCrackedBar.SetActive(false);
        BrokenBar.SetActive(true);
    }
}
