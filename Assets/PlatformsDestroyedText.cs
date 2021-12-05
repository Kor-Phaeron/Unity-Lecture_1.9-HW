using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlatformsDestroyedText : MonoBehaviour
{
    public Text Text;
    public int PlatformsDestroyedNumber;

    // Start is called before the first frame update
    void Start()
    {
        PlatformsDestroyedNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Platforms destroyed: " + PlatformsDestroyedNumber;

        if ((Input.GetKeyDown(KeyCode.Backspace)))
        {
            PlatformsDestroyedNumber++;
            Text.text = "Platforms destroyed: " + PlatformsDestroyedNumber;
        }
    }
}
