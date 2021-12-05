using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text Text;
    public int LevelNumber = 1;


    // Update is called once per frame
    void Update()
    {

        Text.text = "LEVEL: " + LevelNumber;
    }
}
