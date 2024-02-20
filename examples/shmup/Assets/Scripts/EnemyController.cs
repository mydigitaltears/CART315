using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "leftWall" || collision.gameObject.tag == "rightWall") {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, 0);
            moveSpeed *= -1;
        } 
        
    }
}
