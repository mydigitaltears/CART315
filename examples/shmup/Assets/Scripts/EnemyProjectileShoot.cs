using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileShoot : MonoBehaviour
{
    public GameObject enemyProjectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float currCountdownValue;
    public IEnumerator StartCountdown()
    {
        //currCountdownValue = countdownValue;
        currCountdownValue = Random.Range(5.0f, 10.0f);
        while (currCountdownValue >= 0.0f)
        {
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
            if (currCountdownValue <= 1)
            {
                Instantiate(enemyProjectilePrefab, transform.position, Quaternion.identity);
                currCountdownValue = Random.Range(5.0f, 10.0f);
            }
        }

    }
}
