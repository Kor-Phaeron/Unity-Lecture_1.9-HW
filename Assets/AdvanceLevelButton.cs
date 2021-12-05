using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvanceLevelButton : MonoBehaviour
{
    private GameObject Level_Text;
    private GameObject Platform_Text;

    public void AdvanceLevel()
    {
        Level_Text = GameObject.Find("Level_Text");
        LevelText lt = Level_Text.GetComponent<LevelText>();
        lt.LevelNumber++;
    }
    public void RestartPlatforms()
    {
        Platform_Text = GameObject.Find("Platforms_Destroyed_Text");
        PlatformsDestroyedText pt = Platform_Text.GetComponent<PlatformsDestroyedText>();
        pt.PlatformsDestroyedNumber = 0;
    }
}
