using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    //Enemies
    public GameObject asteroid;
    //public GameObject greenRock;
    public GameObject alien;

    public GameObject mainCamera;
    public Player player;

    private float enemy;     // Calculator for distance of player to enemy
    public float spawnDistanceFromPlayer = 50f;
    public float spawnDistanceFromEnemy = 50f;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");   //Import Main Camera
        asteroid = GameObject.Find("Asteroid"); //Import Asteroid
        //greenRock = GameObject.Find("Glowing Rock (Green)"); //Import Glowing Rock (Green)
        alien = GameObject.Find("Alien Floating");
    }

    // Update is called once per frame
    void Update()
    {
        // Setting when to spawn enemies 
        if (enemy < player.mainCamera.transform.position.z) {
            enemy = enemy + spawnDistanceFromEnemy;

            // Dynamically generate asteroids
            Instantiate(asteroid);
            asteroid.transform.position = new Vector3(Random.Range(-10f, 10f), 0, player.mainCamera.transform.position.z + spawnDistanceFromPlayer + 20f);
            
            // Dynamically generate green rocks
            //Instantiate(greenRock);
            //greenRock.transform.position = new Vector3(Random.Range(-10f, 10f), 0, player.mainCamera.transform.position.z + spawnDistanceFromPlayer);

            // Dynamically generate alien
            Instantiate(alien);
            alien.transform.position = new Vector3(Random.Range(-10f, 10f), 0, player.mainCamera.transform.position.z + spawnDistanceFromPlayer);
        }
    }
}
