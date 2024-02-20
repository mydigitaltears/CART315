using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerLives : MonoBehaviour
{

    public int lives = 5;
    public TMP_Text lifeText;

    // Start is called before the first frame update
    void Start()
    {
        //lifeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = lives.ToString();
    }
        
    public void UpdateLives(){
        lives -= 1;
    }
  
    private void OnTriggerEnter2D(Collider2D collision){

      if (collision.gameObject.tag == "enemy1" || collision.gameObject.tag == "enemy2"){
        lives -= 1;

        Destroy(collision.gameObject);

        if (lives <= 0){
            Destroy(gameObject);
        }
      }
    }
}
