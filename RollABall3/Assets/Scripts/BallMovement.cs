using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    Rigidbody movement;
    public float movementSpeed;
    public Text scoreText;
    public Text gameOverText;
    float counter = 0f;
    public int collectibleAmount;
    void Start()
    {
        movement = GetComponent<Rigidbody>();


    }

    
    void FixedUpdate()
    {
        float horizontal1 = Input.GetAxisRaw("Horizontal");
        float vertical1 = Input.GetAxisRaw("Vertical");


        Vector3 vec = new Vector3(horizontal1, 0, vertical1);

        movement.AddForce(vec * movementSpeed);


    }


     void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Collectible")
        {
            other.gameObject.SetActive(false);
            counter++;

            scoreText.text = "SCORE: " + counter;

        }

        if(counter == collectibleAmount)
        {
            gameOverText.text = "GAME OVER!";
        }



    }
}
