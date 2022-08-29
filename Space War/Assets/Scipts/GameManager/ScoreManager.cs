using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance {get; set;}
    
    public void Awake()
    {
        Instance= this;
    }


    public Text scoreText;
    public int score;
    
    
}
