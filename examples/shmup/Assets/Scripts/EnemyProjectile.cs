using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float moveSpeed;
    private PlayerLives playerLives;

    // Start is called before the first frame update
    void Start()
    {
        playerLives = GameObject.Find("player").GetComponent<PlayerLives>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            //Destroy(collision.gameObject);
            playerLives.UpdateLives();
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "bottomWall"){
            Destroy(gameObject);
        }
    }
}
