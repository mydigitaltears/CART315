using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
public Text scoreText;
public int score;
public static scorescript S;





void Awake(){
    S = this;
}
    // Start is called before the first frame update
    void Start()
    {
        score = -1;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Space)) {
         
             UpdateScore();
        }
       
    }

    public void UpdateScore(){
        score += 1;
        scoreText.text = "Score: "+ score +ToString();
       // string scoreDisplay =
    }

}