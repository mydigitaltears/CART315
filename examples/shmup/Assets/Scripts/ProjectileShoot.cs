using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    //refrence to prefab
    public AudioSource shootSound;
    public GameObject projectilePrefab;

     public KeyCode spaceButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(spaceButton)) {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            shootSound.Play(0);
        }
    }
}
