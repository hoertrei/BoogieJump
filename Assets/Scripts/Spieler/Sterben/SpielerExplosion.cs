using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpielerExplosion : MonoBehaviour
{

    Rigidbody2D rb;
    float dirX; //X-Achse
    float dirY; //Y-Achse
    float rotation; //Rotation der einzelnen Teile, welche weg fliegen

    // Start is called before the first frame update
    void Start()
    {
        //Zufällige Werte zuweisen
        dirX = Random.Range(-5,5);
        dirY = Random.Range(5,8);
        rotation = Random.Range(5,15);

        rb = GetComponent<Rigidbody2D>(); //Auf Rigidbody zugreifen
        rb.AddForce(new Vector2(dirX, dirY), ForceMode2D.Impulse); //"Explosion"
        rb.AddTorque(rotation, ForceMode2D.Force); //Rotation
    }
}
