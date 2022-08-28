using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;

    private Transform playerPos;

    private int health =3;
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position,speed*Time.deltaTime);
        Killer();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Bullet")
        {
            health--;
           
        }
    }


    public void Killer()
    {
        if(health ==0)
        {
            Destroy(gameObject);
            SoundController.Instance.gameManager.PlayOneShot(SoundController.Instance.enemyDead[0],0.1f);
        }
    }
}
