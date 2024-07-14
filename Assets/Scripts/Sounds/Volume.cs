using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using BayatGames.SaveGameFree;

public class Volume : MonoBehaviour
{
    public AudioManager audioManager;
    bool vorhanden = false;

    private float value;

    public float volumeSave;
    
    
    public void setVolume(float sliderValue){
        
        foreach (Sound s in audioManager.sounds)
        {
            s.source.volume = sliderValue;
            value = s.source.volume;
        }
    }

    public void Save(){
        SaveGame.Save<float>("volume", value); //Lautstärke speichern
    }

    public bool Vorhanden(){
        vorhanden = SaveGame.Exists("volume");
        return vorhanden;
    }


    public void Laden(){
        //Überprüfen ob Datei schon exisitiert 
        if (Vorhanden())
        {
            volumeSave = SaveGame.Load<float>("volume");
            setVolume(volumeSave);
        }
        
    }
}
