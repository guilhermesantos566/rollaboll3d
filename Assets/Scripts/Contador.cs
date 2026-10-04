using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
public class NewMonoBehaviourScript : MonoBehaviour
{   public TMP_Text timeLevel_txt; 
    public static float timeLevel;
    public static bool stopTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       stopTime=false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(stopTime==false){
            timeLevel=timeLevel + Time.deltaTime; 
            timeLevel_txt.text="Tempo:"+timeLevel.ToString("F0");
        }
      
    }
}
