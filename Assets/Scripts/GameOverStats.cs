using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverStats : MonoBehaviour
{
    public float kills; //
    public float AmmoShot; //
    public float ShotsHit;
    public float StabAtempts; //
    public float StabHit;
    public float hits; //
    public bool cheated = false;

    public float KnifeAccuracy;
    public float GunAccuracy;
    public float OverAllAccuracy;
    public float OverAllHits;
    public float OverAllAttacks;

    public Text KillsText;
    public Text GunShotsText;
    public Text KnifeText;
    public Text OverAllAccuracyText;
    public Text YouCheater;

    public void GameHasDidTheEndingThing()
    {


        OverAllHits = (ShotsHit + StabHit) / 2f;
        OverAllAttacks = (AmmoShot + StabAtempts) / 2f;

        KnifeAccuracy = StabHit / StabAtempts * 100f;
        GunAccuracy = ShotsHit / AmmoShot * 100f;
        OverAllAccuracy = (KnifeAccuracy + GunAccuracy) / 2f;





        if (cheated)
        {
            YouCheater.text = "You cheated >:(";
        } else
        {
            YouCheater.text = "You did not cheat! :)";
        }

        KillsText.text = "Kills: " + kills.ToString();
        GunShotsText.text = "Gun Accuracy: " + GunAccuracy.ToString("0") + "%";
        KnifeText.text = "Knife Accuracy: " + KnifeAccuracy.ToString("0") + "%";
        OverAllAccuracyText.text = "Overall Accuracy Accuracy: " + OverAllAccuracy.ToString("0") + "%";
    }
}
