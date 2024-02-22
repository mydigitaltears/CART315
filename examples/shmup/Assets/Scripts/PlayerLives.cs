using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{

    public int lives = 5;
    public TMP_Text lifeText;

    public AudioSource gettingHitSound;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = lives.ToString();
        if (lives <= 0){
           Debug.Log("GameOver");
           SceneManager.LoadScene("GameOver");
        }
    }
        
    public void UpdateLives(){
        lives -= 1;
        gettingHitSound.Play(0);
    }
  
    private void OnTriggerEnter2D(Collider2D collision){
        
      if (collision.gameObject.tag == "enemy1" || collision.gameObject.tag == "enemy2"){
        Debug.Log("Collision works");
        UpdateLives();

        Destroy(collision.gameObject);
      }
    }
}
