using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using BayatGames.SaveGameFree;

public class ShopManagerScript : MonoBehaviour
{
    int coinBetrag;

    public CoinsAktualisieren coinsAktualisieren;
    public SpielerBewegung spielerBewegung;
    [HideInInspector]public CoinZähler coinZaehler;
    public Leben leben;

    private Rigidbody2D rb;

    bool vorhandenCoins;
    bool vorhandenHerz;

    int heartsSave;

    // Zum eintragen des Inspector für die jeweiligen Werte
    public TextMeshProUGUI coinsText;

    public Button buyButtonHerz;
    public Button buyButtonJumpBoost;
    public Button buyButtonDoppelteCoinChance;
    public Button buyButtonSlowFalling;
    public Button buyButtonCoinMultiplikator;
    public Button buyButtonLottery;

    public TextMeshProUGUI herzPreis;
    public TextMeshProUGUI jumpboostPreis;
    public TextMeshProUGUI doppelteCoinChancePreis;
    public TextMeshProUGUI slowFallingPreis;
    public TextMeshProUGUI coinMultiplikatorPreis;
    public TextMeshProUGUI lotteryPreis;

    private int herzGekauft;
    private int doppelteCoinChanceGekauft;
    private bool slowFallingGekauft;
    private bool coinMultipliaktorGekauft;
    private bool jumpBoostGekauft;
    private bool lotteryeGekauft;

    //------------------------------------------------------------------------------------------------------------------------------------------------------------//
    // Notiz für Preise:
    //
    // Primäre Upgrades:
    //---------------------------------
    // 1.Herz:                   1000 $
    // 2.Herz:                   2500 $  
    // 1.Doppelte Coin Chance:    200 $
    // 2.Doppelte Coin Chance:    500 $
    // 3.Doppelte Coin Chance:   1000 $
    // 4.Doppelte Coin Chance:   1500 $
    //---------------------------------
    //
    // Tämporere Upgrades:
    //------------------------------
    // Slow Falling:            50 $
    // Speed:                   50 $
    // Coin Multiplikator:      50 $
    // Lottery:                100 $
    //------------------------------------------------------------------------------------------------------------------------------------------------------------//

    public void Start()
    {
        rb = GameObject.Find("Spieler").GetComponent<Rigidbody2D>();

        if (herzGekauft == 0)
        {
            leben.health = 1;
            leben.numOfHearts = 1;
        }
        else if (herzGekauft == 1)
        {
            leben.health = 2;
            leben.numOfHearts = 2;
        }
        else if (herzGekauft == 2)
        {
            leben.health = 3;
            leben.numOfHearts = 3; 
        }

    }

    void Update()
    {
        coinsText.text = coinBetrag.ToString() + "$";

        // Herz
        if (coinBetrag >= 1000 && herzGekauft == 0)
        {
            buyButtonHerz.interactable = true;
            herzPreis.text = "1000$";
        }
        else if (coinBetrag >= 2500 && herzGekauft == 1)
        {
            buyButtonHerz.interactable = true;
            herzPreis.text = "2500$";

        }
        else if (herzGekauft == 2)
        {
            buyButtonHerz.interactable = false;
            herzPreis.text = "Sold!";
        }
        else
        {
             buyButtonHerz.interactable = false;
        }

        // Doppelte Coin Chance
        /*
        if (coinBetrag >= 200 && doppelteCoinChanceGekauft <= 0)
        {
            buyButtonDoppelteCoinChance.interactable = true;
            doppelteCoinChancePreis.text = "200$";
        }
        else if (coinBetrag >= 500 && doppelteCoinChanceGekauft <= 1)
        {
            buyButtonDoppelteCoinChance.interactable = true;
            doppelteCoinChancePreis.text = "500$";
        }
        else if (coinBetrag >= 1000 && doppelteCoinChanceGekauft <= 2)
        {
            buyButtonDoppelteCoinChance.interactable = true;
            doppelteCoinChancePreis.text = "1000$";
        }
        else if (coinBetrag >= 1500 && doppelteCoinChanceGekauft <= 3)
        {
            buyButtonDoppelteCoinChance.interactable = true;
            doppelteCoinChancePreis.text = "1500$";
        }
        else
        {
            buyButtonDoppelteCoinChance.interactable = false;
            doppelteCoinChancePreis.text = "Sold!";
        }
        */

        // Slow Falling
        if (coinBetrag >= 50 && slowFallingGekauft == false)
        {
            buyButtonSlowFalling.interactable = true;
        }
        else
        {
            buyButtonSlowFalling.interactable = false;
        }

        // Coin Multiplikator
        if (coinBetrag >= 50 && coinMultipliaktorGekauft == false)
        {
            buyButtonCoinMultiplikator.interactable = true;
        }
        else
        {
            buyButtonCoinMultiplikator.interactable = false;
        }

        // Jump Boost
        if (coinBetrag >= 50 && jumpBoostGekauft == false)
        {
            buyButtonJumpBoost.interactable = true;
        }
        else
        {
            buyButtonJumpBoost.interactable = false;
        }

        // Lottery
        /*
        if (coinBetrag >= 100 && lotteryeGekauft == false)
        {
            buyButtonLottery.interactable = true;
        }
        else
        {
            buyButtonLottery.interactable = false;
        }
        */
    }

    /*
       public void Kaufen(int itemGekauft, int preis, Button buyButton)
       {
           if (coinBetrag >= preis && itemGekauft == 0)
           {
               buyButton.interactable = true;
           }
           else
           {
               buyButton.interactable = false;
           }
       }
    */

    public void HerzKaufen()
    {

        if (coinBetrag >= 1000 && herzGekauft <= 0)
        {
            coinBetrag -= 1000;
        }
        else if (coinBetrag >= 2500 && herzGekauft <= 1)
        {
            coinBetrag -= 2500;
        }

        herzPreis.text = "2500$";

        herzGekauft++;

        leben.numOfHearts++;
        leben.health++;

        Save();



    }
    public void DoppelteCoinChanceKaufen()
    {
        /*
        coinBetrag -= 200;
        doppelteCoinChanceGekauft++;
        */

    }
    public void SlowFallingKaufen()
    {
        coinBetrag -= 50;
        slowFallingPreis.text = "Sold!";
        slowFallingGekauft = true;

        rb.gravityScale = 0.5f;
        spielerBewegung.sprungHoehe = 5.8f;
    }
    public void CoinMultiplikatorKaufen()
    {
        coinBetrag -= 50;
        coinMultiplikatorPreis.text = "Sold!";
        coinMultipliaktorGekauft = true;

        CoinZähler.coinValue = 2;
    }
    public void JumpBoostKaufen()
    {
        coinBetrag -= 50;
        jumpboostPreis.text = "Sold!";
        jumpBoostGekauft = true;

        spielerBewegung.sprungHoehe = 11;
    }
    public void LotteryKaufen()
    {
        /*
        coinBetrag -= 100;
        lotteryPreis.text = "Sold!";
        lotteryeGekauft = true;
        */
    }

    public void CoinsAktualisieren()
    {
        coinBetrag = coinsAktualisieren.GetCoins();
    }

    public void Save()
    {
        SaveGame.Save<int>("coins", coinBetrag);  //Coin abzug speichern
        SaveGame.Save<int>("hearts", herzGekauft); //Herz gekauft speichern
    }

    public bool VorhandenCoins()
    {
        vorhandenCoins = SaveGame.Exists("coins");
        return vorhandenCoins;
    }

    public bool VorhandenHerz()
    {
        vorhandenHerz = SaveGame.Exists("hearts");
        return vorhandenHerz;
    }

    public void Laden()
    {
        //Überprüfen ob Datei schon exisitiert 
        if (VorhandenHerz())
        {
            heartsSave = SaveGame.Load<int>("hearts");
            ChangeHearts(heartsSave);
        }

    }

    public void ChangeHearts(int hearthValue)
    {
        herzGekauft += hearthValue;
    }

    public void SlowJump(){
        if (slowFallingGekauft == true && jumpBoostGekauft == true)
        {
            spielerBewegung.sprungHoehe = 8;
        }
    }


}
