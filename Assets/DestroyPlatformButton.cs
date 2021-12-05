using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatformButton : MonoBehaviour
{
    private GameObject Platform_Text;


    public void DestroyPlatform()
    {
        Platform_Text = GameObject.Find("Platforms_Destroyed_Text");
        PlatformsDestroyedText pt = Platform_Text.GetComponent<PlatformsDestroyedText>();

        pt.PlatformsDestroyedNumber++;
    }
}

