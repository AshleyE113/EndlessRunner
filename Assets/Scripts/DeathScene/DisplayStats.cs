using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/* This allows the score and apple count to be displayed in the death scene. It uses AddComponent
 * since you can't "link" scripts across scenes. The AddComponent allows the script to access the Holder
 * variables.
 */
public class DisplayStats : MonoBehaviour
{
    /*
    ScoreKeeper score;
  
    //[SerializeField] private TMP_Text scoreDisplay;
    [SerializeField] private TMP_Text appleDisplay;
    TextMeshPro str;

    void Start()
    {
       score = gameObject.AddComponent(typeof(ScoreKeeper)) as ScoreKeeper; 
       //scoreDisplay.SetText("Score: " + score.str);
       appleDisplay.SetText("Apples: " + score.appleHolder.ToString());

    }
    */
}
