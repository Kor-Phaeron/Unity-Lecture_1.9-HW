using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseLevelButton : MonoBehaviour
{
    private GameObject Level_Text;


    public void DecreaseLevel()
    {
        Level_Text = GameObject.Find("Level_Text");
        LevelText lt = Level_Text.GetComponent<LevelText>();

        if (lt.LevelNumber > 1)
            lt.LevelNumber--;
        
    }
}
