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
    public GameObject boss;
    public int enemyNb;

    private int waves = 1;
    private AudioSource audiosource;
    private int enemyKilledCount = 0;

    private GameObject[] gnomes;
    private GameObject[] gnomesDead;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        SpawnEnemies(enemies, 4, waves);
        enemyKilledCount = 0;
    }

    void Update()
    {

    }

    public void UpdateScore(int points){
        score += points;
        scoreText.text = "Score: " + score;// Decrease the score by subtracting the points

        audiosource.Play(0);

        enemyKilledCount += 1;

        if(enemyNb == enemyKilledCount)
        {
            waves += 1;
            enemies.GetComponent<EnemyController>().moveSpeed += 2;

            gnomes = GameObject.FindGameObjectsWithTag("gnome");
            for (int i = 0; i < gnomes.Length; i++)
            {
                Destroy(gnomes[i]);
            }
            gnomesDead = GameObject.FindGameObjectsWithTag("gnomeDead");
            for (int i = 0; i < gnomesDead.Length; i++)
            {
                Destroy(gnomesDead[i]);
            }
            SpawnEnemies(enemies, 4, waves);
            enemyKilledCount = 0;
        }

        if (score >= 1000){
            SceneManager.LoadScene("GameWin");
        }
    }

        public void DecreaseScore(int points)
    {
        score -= points;
        scoreText.text = "Score: " + score;// Decrease the score by subtracting the points

        audiosource.Play(0);
    }

    public void SpawnEnemies(GameObject enemies, int columns, int rows){
            enemies.GetComponent<EnemyController>().rows = rows;
            enemies.GetComponent<EnemyController>().columns = columns;
            enemyNb = 3 * rows;
            Instantiate(enemies, new Vector3(0f, 5f, 0f), Quaternion.identity);
    }
}
