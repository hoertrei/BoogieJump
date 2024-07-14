using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TodesStartbildschirm : MonoBehaviour
{

    public void Anzeigen(){
        gameObject.SetActive(true);
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0); //Spiel neustarten
    }

    public void Verlassen(){
        Application.Quit();
    }


}
