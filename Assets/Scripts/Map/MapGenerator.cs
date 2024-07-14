using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public MainStartbildschirm mainStartbildschirm;

    private enum Schwierigkeit{
        Leicht, Mittel, Schwierig, Unmöglich
    }
    private const float player_distance_spawn_level_part = 100f; //Ab wann neuer MapPart geladen werden soll
    [SerializeField] private Transform mapPart_Start; //Start vom ersten Map Part
    [SerializeField] private List<Transform> levelPartEasyList; //Liste mit verschiedenen Parts
    [SerializeField] private List<Transform> levelPartMediumList; //Liste mit verschiedenen Parts
    [SerializeField] private List<Transform> levelPartHardList; //Liste mit verschiedenen Parts
    [SerializeField] private List<Transform> levelPartImpossibleList; //Liste mit verschiedenen Parts
    
    private Vector3 lastEndPosition; //Endposition des Map Parts

    private int levelPartCounter;

    private void Awake() {
        //Map Parts vorladen
        lastEndPosition = mapPart_Start.Find("MapPart_End").position;
        int startingLevelParts = 5;

        for (int i = 0; i < startingLevelParts; i++)
        {
            SpawnMapPart();
        }
    }

    private void Update() {
        //Map Parts laden, wenn Spieler am Ende von einem Map Part angelangt ist
        try
        {
            if (Vector3.Distance(GameObject.FindGameObjectsWithTag("Player")[0].transform.position, lastEndPosition) < player_distance_spawn_level_part)
            {
                //Weiteren Map-Part spawnen
                SpawnMapPart();
            } 
        }
        catch (System.Exception)
        {
            
        }

    }

    private void SpawnMapPart(){
        if (!mainStartbildschirm.isActiveAndEnabled)
        {
            List<Transform> schwierigkeitMapPartList;

        switch (getSchwierigkeit())
        {        
            default: 
            case Schwierigkeit.Leicht:      schwierigkeitMapPartList = levelPartEasyList; break;
            case Schwierigkeit.Mittel:      schwierigkeitMapPartList = levelPartMediumList; break;
            case Schwierigkeit.Schwierig:   schwierigkeitMapPartList = levelPartHardList; break;
            case Schwierigkeit.Unmöglich:   schwierigkeitMapPartList = levelPartImpossibleList; break;
            
        }

        Transform randomMapPart = schwierigkeitMapPartList[Random.Range(0, schwierigkeitMapPartList.Count)]; //Einfacher Map-Part

        lastEndPosition.z = 0; //Z-Koordinate auf 0 setzen, damit nicht jeder Map Part höhere Z-Koordinate hat
        Transform lastMapPartTransform = SpawnMapPart(randomMapPart, lastEndPosition); //Größe des generierten Map-Parts bekommen
        lastEndPosition = lastMapPartTransform.Find("MapPart_End").position; //Aktuelle End-Position des aktuellen Map-Parts
        levelPartCounter++;
        }
        
    }

    private Transform SpawnMapPart(Transform levelPart, Vector3 spawnPosition){
        Transform mapPart = Instantiate(levelPart, spawnPosition, Quaternion.identity); //Gibt einen Clone von einem zufälligem Map-Part zurück
        return mapPart;
        
    }

    private Schwierigkeit getSchwierigkeit(){
        if (levelPartCounter >= 30) return Schwierigkeit.Unmöglich;
        if (levelPartCounter >= 20) return Schwierigkeit.Schwierig;
        if (levelPartCounter >= 10) return Schwierigkeit.Mittel;
        return Schwierigkeit.Leicht;
        
    }
}
