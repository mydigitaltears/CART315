using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public GameObject enemies;

    private int waves = 1;
    private int lastScore = 0;
    private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        SpawnEnemies(enemies, 4, waves);
    }

    public void UpdateScore(int points){
        score += points;
        scoreText.text = "Score: " + score;
        if(score > 0){
            audiosource.Play(0);
        }
        if (score == 200*waves + lastScore){
            waves += 1;
            lastScore = score;
            SpawnEnemies(enemies, 4, waves);
        }
        if (score >= 5000){
            SceneManager.LoadScene("GameWin");
        }
    }

    public void SpawnEnemies(GameObject enemies, int columns, int rows){
            enemies.GetComponent<EnemyController>().rows = rows;
            enemies.GetComponent<EnemyController>().columns = columns;
            Instantiate(enemies, new Vector3(0f, 5f, 0f), Quaternion.identity);
    }
}
