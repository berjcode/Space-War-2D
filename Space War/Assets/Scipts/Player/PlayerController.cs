using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject PlayerBullet;
    public GameObject  playerBullet2;

    public GameObject bulletPositionFirst;
    public GameObject bulletPosiitonSecond;
   public float speed;



   void Start()
   {

   }


   void Update()
   {
       FireSystem1();
       FireSystem2();

       

        float x = Input.GetAxisRaw("Horizontal");
        float y= Input.GetAxisRaw("Vertical");


        Vector2 direction = new Vector2 (x,y).normalized;

        Move(direction);
   }

 #region  FireSystem 
   public void FireSystem1()
   {

    
    if(Input.GetMouseButtonDown(0))
        {
            GameObject bullet01 = (GameObject)Instantiate (PlayerBullet);
            bullet01.transform.position = bulletPositionFirst.transform.position;
            SoundController.Instance.gameManager.PlayOneShot(SoundController.Instance.fireShoot[0],0.5f);


        
        }
   }


   public void FireSystem2()
   {
    if(Input.GetKeyDown("space"))
        {
            GameObject bullet02 = (GameObject) Instantiate (playerBullet2);
            bullet02.transform.position = bulletPosiitonSecond.transform.position;
            SoundController.Instance.gameManager.PlayOneShot(SoundController.Instance.fireShoot[1],0.05f);
        }
   }
    #endregion
    #region Move
   void Move( Vector2 direction)
   {
        Vector2 min=Camera.main.ViewportToWorldPoint (new Vector2 (0,0));
        Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2(1,1));

        max.x = max.x - 0.225f;
        min.x = min.x +0.225f;

        max.y = max.y -0.285f;
        min.y = min.y +0.285f;


        Vector2 pos = transform.position;

        pos += direction * speed*Time.deltaTime;


        pos.x = Mathf.Clamp (pos.x,min.y,max.x);
        pos.y = Mathf.Clamp(pos.y,min.y,max.y);

        transform.position = pos;



   }

#endregion

void FixedUpdate()
{
    
     #region Horizontal Limit
        if (transform.position.x >2.39f)
        {
            Vector2 rightLimit = new Vector2(2.39f, transform.position.y);
            transform.position = rightLimit;
        }
        
        if (transform.position.x < -2.39f)
        {
            Vector2 leftLimit = new Vector2(-2.39f, transform.position.y);
            transform.position = leftLimit;
        }



        #endregion

}


}

