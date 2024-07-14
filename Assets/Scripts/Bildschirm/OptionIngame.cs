using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionIngame : MonoBehaviour
{
    public static bool gameIsPaused = false;

    private SpielerActionControls spielerActionControls;

    [SerializeField] CoinsAktualisieren coinsAktualisieren;
    [SerializeField] Volume volume;

    private GameObject optionIngame;
    private GameObject lebensanzeige;

    private void Awake() {
        optionIngame = GameObject.Find("OptionIngame");
        lebensanzeige = GameObject.Find("Lebensanzeige");
        spielerActionControls = new SpielerActionControls();
    }

    private void OnEnable(){
        spielerActionControls.Enable();
    }

    private void OnDisable(){
        spielerActionControls.Disable();
    }

    [System.Obsolete]
    private void Start() {
        optionIngame.SetActive(false);
        lebensanzeige.SetActive(false);


        spielerActionControls.Immer.Pause.performed += _ => SchauenObPause();
        
        
    }

    private void SchauenObPause()
    {
        if (gameIsPaused)
        {
            Resume();
        }
        else {
            Paused();
        }
        
    }

    public void Resume()
    {
        optionIngame.SetActive(false);
        lebensanzeige.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    private void Paused()
    {
        optionIngame.SetActive(true);
        lebensanzeige.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Speichern(){
         //Speichern
         if (GameObject.Find("MainStartbildschirm").activeInHierarchy == false)
         {
             coinsAktualisieren.Save();
         }
         
         volume.Save();
           
    }
}
