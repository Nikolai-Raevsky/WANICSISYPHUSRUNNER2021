
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour
{ 

    private float yPosition = 0.0f;
    private GameObject player = null;
    private Rigidbody2D physics = null;
    private float height;
    public float topHeight;
    public float bottomHeight;
    //Set a public variable that controls the vertical boulder movement
    public float ObstacleDirection;
    private float RH;

    // Start is called before the first frame update
    void Start()
    {
        yPosition = transform.position.y;
        player = GameObject.Find("Player");
        physics = gameObject.GetComponent<Rigidbody2D>();
        height = Random.Range(bottomHeight, topHeight);
        RH = Random.Range(0f, height);
        transform.position = (new Vector3(50, RH, 0));
        //Assign value to the vertical boulder velocity here

    }

    // Update is called once per frame
    void Update()
    {
        //Stop boulders from rising too high
        if (gameObject.GetComponent<Transform>().position.y > height)
        {
            ObstacleDirection *= -1;
        }

        transform.Rotate(0, 0, Time.deltaTime * (-5 * -9.5f), Space.World);
        float moveSpeed = -10.0f;

        if (player != null)
        {
            moveSpeed = -player.GetComponent<PlayerMovementController>().MoveSpeed;
        }
        yPosition -= ObstacleDirection;
        physics.velocity = new Vector3(moveSpeed, 0, 0);
        transform.position = new Vector3(transform.position.x,
            yPosition + ObstacleDirection * Time.deltaTime, transform.position.z);

 
    }

    //Use this function to stop the boulders from sinking too far.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Floor"))
        {
            ObstacleDirection *= -1;
        }
    }
}
