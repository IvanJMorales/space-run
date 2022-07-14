using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Google.XR.Cardboard;
using System.Collections;

public class Player : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject player;
    

    public float forwardSpeed = 10f;
    public float maxSpeed = 5f;

    private CharacterController controller;

    private Vector3 direction;

    void Start()
    {

        mainCamera = GameObject.Find("Main Camera");   //Import mainCamera (Parent of the VR Camera)
        player = GameObject.Find("Player");  //Import the spaceship 
    }

    // Update is called once per frame
    void Update()
    {
        forwardSpeed += 1.0f;


        if (forwardSpeed > maxSpeed) {
            forwardSpeed = maxSpeed;
        }

        //Move player avatar left and right with tilt of device
        Vector3 movementDirection = new Vector3(Input.acceleration.x / 10, 0, forwardSpeed /20);
        transform.Translate(movementDirection);

        // Make player stay in hidden walls
        if (player.transform.position.x < -12f) {   // Left Edge
            player.transform.position = new Vector3(player.transform.position.x + 0.1f, player.transform.position.y, player.transform.position.z);
        } else if (player.transform.position.x > 12f) {   // Right Edge
            player.transform.position = new Vector3(player.transform.position.x - 0.1f, player.transform.position.y, player.transform.position.z);
        }

    }

    // I
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Asteroid" || col.gameObject.name == "Asteroid(Clone)")
        {
            SceneManager.LoadScene("GameOver");
        }
        //else if (col.gameObject.name == "Glowing Rock" || col.gameObject.name == "Glowing Rock(Green)(Clone)")
        //{
            //SceneManager.LoadScene("GameOver");
        //}
        else if (col.gameObject.name == "Alien Floating" || col.gameObject.name == "Alien Floating(Clone)")
        {
            SceneManager.LoadScene("SpaceFacts");
        }
    }

}




























   /* public GameObject mainCamera;
    public GameObject spaceship;

    public float forwardSpeed;

    private CharacterController controller;

    private Vector3 direction;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        mainCamera = GameObject.Find("Main Camera");   //Import mainCamera (Parent of the VR Camera)
        spaceship = GameObject.Find("Spaceship");  //Import the spaceship 
    }

    // Update is called once per frame
    void Update()
    {
        //direction.z = forwardSpeed;


        //Move player avatar with tilt of device
        //transform.Translate(Input.acceleration.x, 0, Input.acceleration.z);

        //transform.Rotate(Input.acceleration.x, 0, 0);
    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.deltaTime);

    }*/
