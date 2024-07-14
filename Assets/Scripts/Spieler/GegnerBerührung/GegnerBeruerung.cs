using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GegnerBeruerung : MonoBehaviour
{

    [SerializeField] private GameObject body, leftArm, rightArm, leftEye, rightEye, leftFoot, rightFoot, leftHand, rightHand, effekt;

    public TodesStartbildschirm todesStartbildschirm;
    public SpielerBewegung spielerBewegung;
    //public CoinZähler coinZaehler;

    //Speichern
    public CoinsAktualisieren coinsAktualisieren;
    public Volume volume;
    private Rigidbody2D rb;

    private void Start() {
         rb = GameObject.Find("Spieler").GetComponent<Rigidbody2D>();
    }

    private void BlutEffekt(){
        Instantiate(effekt, transform.position, Quaternion.identity);
    }
    public void Explosion(){

        //Standardwerte setzten
        spielerBewegung.sprungHoehe = 8;
        rb.gravityScale = 1;
        CoinZähler.coinValue = 1;

        //Kopie erstllen
        Instantiate(body, transform.position, Quaternion.identity);
        Instantiate(leftArm, transform.position, Quaternion.identity);
        Instantiate(rightArm, transform.position, Quaternion.identity);
        Instantiate(leftEye, transform.position, Quaternion.identity);
        Instantiate(rightEye, transform.position, Quaternion.identity);
        Instantiate(leftFoot, transform.position, Quaternion.identity);
        Instantiate(rightFoot, transform.position, Quaternion.identity);
        Instantiate(leftHand, transform.position, Quaternion.identity);
        Instantiate(rightHand, transform.position, Quaternion.identity);

        Speichern();
        
        gameObject.SetActive(false); //Spieler entfernen
}

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.transform.tag == "Gegner") //Wenn Spieler Gegner berührt
        {
            //Falls Spieler noch Leben hat, dann Leben abziehen
            if (gameObject.GetComponent<Leben>().health > 1)
            {             
                gameObject.GetComponent<Leben>().health -= 1;

                //DamageSound
                FindObjectOfType<AudioManager>().Play("Schaden");

                //Damage-Partikel
                BlutEffekt();

            }
            else
            {
                //Damage-Partikel
                BlutEffekt();
                
                //TodesSound
                FindObjectOfType<AudioManager>().Play("SpielerTod");

                Explosion();

               //TodesBildschirm anzeigen
               todesStartbildschirm.Anzeigen();
               GameObject.Find("Lebensanzeige").SetActive(false);

            }                   
        }
        
        //Wenn man runter fällt:
        if(other.transform.tag == "DeathBorder" && other.transform.tag == "DeathBorder" != false ){

            //Damage-Partikel
            BlutEffekt();
            
            //TodesSound
            FindObjectOfType<AudioManager>().Play("SpielerTod");

            Explosion();

            //TodesBildschirm anzeigen
            todesStartbildschirm.Anzeigen();
            GameObject.Find("Lebensanzeige").SetActive(false); 
        }
    }

    private void Speichern(){
         //Speichern wenn man Stirbt
         coinsAktualisieren.Save();
         volume.Save();
           
    }

}
