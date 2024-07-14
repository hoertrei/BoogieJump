using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinZähler : MonoBehaviour
{
    [HideInInspector]public static int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            CoinsAktualisieren.coinsAktualisieren.ChangeCoins(coinValue);
        }
    }
}
