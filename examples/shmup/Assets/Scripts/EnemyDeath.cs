using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDeath : MonoBehaviour
{
    public GameObject flower1;
    public GameObject flower2;
    public GameObject flower3;

    private GameObject[] flowers = new GameObject[3];
    private bool isQuitting = false;
    // Start is called before the first frame update
    void Start()
    {
        flowers[0] = flower1;
        flowers[1] = flower2;
        flowers[2] = flower3;
    }

    // Update is called once per frame
    void OnDestroy() {
        if (!isQuitting){
            int flowerNum = Random.Range(0,3);
            //Debug.Log(flowerNum);
            Instantiate(flowers[flowerNum], transform.position, Quaternion.identity);
        }
    }

    void OnApplicationQuit(){
        isQuitting = true;
    }

    //SceneManager.sceneLoaded += OnSceneLoaded;
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        isQuitting = true;
    }
}
