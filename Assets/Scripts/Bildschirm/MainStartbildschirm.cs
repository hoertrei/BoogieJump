using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainStartbildschirm : MonoBehaviour
{
    public static bool gameIsPaused = true;
    public Volume volume;

    public Slider sliderStartbildschirm;
    public Slider sliderIngame;

    public ShopManagerScript shopManagerScript;
    public CoinsAktualisieren coinsAktualisieren;
    
    private void Update() {
        VolumeLaden();
    }

     void Resume()
    {
        GameObject.Find("MainStartbildschirm").SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Paused()
    {
        GameObject.Find("MainStartbildschirm").SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void PlayGame(){

        Resume();
        Laden();
    }

    private void Start() {
        Paused();
        volume.setVolume(0.1f);
        shopManagerScript.Laden();
    }

    public void QuitGame(){
        
        Application.Quit();
    }

    public void Laden(){
        //Wenn man Spiel startet, sollen Dateien geladen werden (Coins usw.)
        coinsAktualisieren.Laden();
        shopManagerScript.Laden();
        VolumeLaden();
    }

    public void VolumeLaden(){
        volume.Laden();
        
        sliderStartbildschirm.value = volume.volumeSave;
        sliderIngame.value = volume.volumeSave;
    }
}
