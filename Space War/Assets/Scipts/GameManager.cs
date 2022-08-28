using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance {get; set;}

    public void Awake()
    {
        Instance =this;
    }
    public int healthPlayer =50;

    public Text healthText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerKill();
    }

    void PlayerKill()
    {
        if(healthPlayer ==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
           
        }
    }

}
