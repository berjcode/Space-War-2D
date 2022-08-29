using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{


    public static SoundController Instance {get; set;}

    void Awake()
    {
        Instance = this;
    }
    public AudioSource gameManager;
   public AudioClip[] fireShoot;

   public AudioClip[] enemyDead;
   


}
