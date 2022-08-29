using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerAndroidController : MonoBehaviour
{
    float Horizontal;
    float Vertical;
    public Rigidbody2D playerRig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            Horizontal = Input.acceleration.x;
            


        }
        playerRig.velocity = new Vector2(Horizontal * 8f, playerRig.velocity.y);
    }
}
