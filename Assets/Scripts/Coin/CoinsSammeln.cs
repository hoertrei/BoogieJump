using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSammeln : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        //Wenn ein Objekt mit dem Tag "Coin" berührt wird
        if (other.transform.tag == "Coin")
        {
            //Coinsound
            FindObjectOfType<AudioManager>().Play("Coins");
            Destroy(other.gameObject);
        }
    }

}
