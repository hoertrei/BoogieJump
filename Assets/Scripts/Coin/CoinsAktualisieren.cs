using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using BayatGames.SaveGameFree;

public class CoinsAktualisieren : MonoBehaviour
{

    public static CoinsAktualisieren coinsAktualisieren;
    [SerializeField]private TextMeshProUGUI text;
    public int coins;
    bool vorhanden = false;
    int coinsSave;

    // Start is called before the first frame update
    void Start()
    {
        SaveGame.Encode = true;

        if (coinsAktualisieren == null)
        {
            coinsAktualisieren = this;
        }

    }

    public void ChangeCoins(int coinValue){
        coins += coinValue;
        text.text = "X" + coins.ToString();
    }

    public void Save(){
        SaveGame.Save<int>("coins", coins); //Coins speichern
    }

    public bool Vorhanden(){
        vorhanden = SaveGame.Exists("coins");
        return vorhanden;
    }

    public void Laden(){
        //Überprüfen ob Datei schon exisitiert 
        if (Vorhanden())
        {
            coinsSave = SaveGame.Load<int>("coins");
            ChangeCoins(coinsSave);
        }
    }

    public int GetCoins(){
        coinsSave = SaveGame.Load<int>("coins");
        return coinsSave;
    }
}
