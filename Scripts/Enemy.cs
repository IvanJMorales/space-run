using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyLifetime;
    public GameObject asteroid;
    public GameObject GlowingRock;
    
    // Start is called before the first frame update
    void Start()
    {

        enemyLifetime = 10;
        asteroid = GameObject.Find("Asteroid");
    }

    // Update is called once per frame
    void Update()
    {
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Alien Floating" || col.gameObject.name == "Alien Floating(Clone)")
        {
        }
    }
    }
}
