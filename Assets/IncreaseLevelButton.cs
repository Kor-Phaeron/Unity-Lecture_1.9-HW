using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseLevelButton : MonoBehaviour
{
    private GameObject Level_Text;


    public void InreaceLevel()
    {
        Level_Text = GameObject.Find("Level_Text");
        LevelText lt = Level_Text.GetComponent<LevelText>();

        lt.LevelNumber++;
    }
}
