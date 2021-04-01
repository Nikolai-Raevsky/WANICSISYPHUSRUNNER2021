using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBoulder : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedTop = -11f;
    public float speedBottom = -5f;
    float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = (new Vector3(50,-1.5f,0));
        speed = Random.Range(speedBottom, speedTop);
    }
   
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, 0);
        transform.Rotate(0, 0, Time.deltaTime * (speed * -9.5f), Space.World);     
    }
}
