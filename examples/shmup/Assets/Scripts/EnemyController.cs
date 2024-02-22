using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;
    public GameObject enemy1;
    public GameObject enemy2;
    public int rows, columns;

    public float enemySpacing_h;
    public float enemySpacing_v;

    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i < columns+1; i++){
            for(int j = 0; j < rows; j++){
                float coinFlip = Random.Range(0,2);
                float xPos = Mathf.Lerp(-columns*enemySpacing_h, columns*enemySpacing_h, ((float)i/((float)columns+1)));
                float yPos = (this.transform.position.y + rows) - (j * enemySpacing_v);
                Debug.Log(coinFlip);
                if (coinFlip >= 0.5){
                    Instantiate(enemy1, new Vector3(xPos, yPos, 0f), Quaternion.identity, this.transform);
                }
                else {
                    Instantiate(enemy2, new Vector3(xPos, yPos, 0f), Quaternion.identity, this.transform);
                }
            }
        }
        //bc.offset = new Vector2(0f, -4f);
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
