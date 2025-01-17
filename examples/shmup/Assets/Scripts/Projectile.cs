using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float moveSpeed;
    
    private PointManager pointManager;
   
    // Start is called before the first frame update
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "enemy1"){
            Destroy(collision.gameObject);
            pointManager.UpdateScore(50);
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "enemy2"){
            Destroy(collision.gameObject);
            pointManager.UpdateScore(50);
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "gnome"){
                    Destroy(collision.gameObject);
                    pointManager.DecreaseScore(200);
                    Destroy(gameObject);
        }


        if(collision.gameObject.tag == "topWall"){
            Destroy(gameObject);
        }
    }
}
