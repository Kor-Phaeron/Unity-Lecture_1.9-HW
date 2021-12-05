using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructPlatformButton : MonoBehaviour
{
    private GameObject Platform_Text;


    public void ConstructPlatform()
    {
        Platform_Text = GameObject.Find("Platforms_Destroyed_Text");
        PlatformsDestroyedText pt = Platform_Text.GetComponent<PlatformsDestroyedText>();

        if (pt.PlatformsDestroyedNumber > 0)
        pt.PlatformsDestroyedNumber--;
    }
}
