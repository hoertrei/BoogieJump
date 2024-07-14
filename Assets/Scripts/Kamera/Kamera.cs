using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{

    //Wen die Kamera verfolgen soll
    [SerializeField] private Transform verfolgung;

    //Wie weit die Kamera vom Spieler entfernt ist
    [SerializeField] private Vector3 entfernung;

    //Schnelligkeit der Kamera
    private Vector3 geschwindigkeit = Vector3.zero;

    //Gibt an, wie flüssig sich die Kamera bewegen soll
    [SerializeField] private float smoothGeschwindigkeit = 0.125f;   

    // Update is called once per frame
    void Update()
    {
        //Aktuelle Position des Spielers
        Vector3 positionSpieler = verfolgung.position + entfernung;

        //Position der Kamera updaten (Spieler verfolgen)
        transform.position = Vector3.SmoothDamp(transform.position, positionSpieler, ref geschwindigkeit, smoothGeschwindigkeit);
    }


}
