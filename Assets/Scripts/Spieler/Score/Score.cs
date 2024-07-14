using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public Transform spieler;
    public TextMeshProUGUI scoreText;

    float startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = spieler.position.x;
        scoreText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {     
        scoreText.text = $"Score: {(spieler.position.x - startPos).ToString("0")}m";
    }
}
