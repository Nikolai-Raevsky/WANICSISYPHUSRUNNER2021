//------------------------------------------------------------------------------
//
// File Name:	Obstacle.cs
// Author(s):	Jeremy Kings (j.kings) - Unity Project
//              Nathan Mueller - original Zero Engine project
// Project:		Endless Runner
// Course:		WANIC VGP
//
// Copyright © 2021 DigiPen (USA) Corporation.
//
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public bool DestroyOnPlayerCollision = true;
    public int Damage = 1;
    public float DestroyXLimit = -10.0f;               
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {        
        if(transform.position.x <= DestroyXLimit)
        {
            Destroy(gameObject);
        }
    }    
}
