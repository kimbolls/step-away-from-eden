﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public gametile gametile;
  
    public Rigidbody2D rb; 

    Vector3 startingpoint;
    Vector3 nextpoint;

    private int i = 5;

    public Transform playerposition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingpoint = gametile.values[i].transform.position;
        playerposition.position = startingpoint;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("d"))
        {
            GoRight();
        }
        if(Input.GetKeyDown("a"))
        {
            GoLeft();
        }
        if(Input.GetKeyDown("w"))
        {
            GoUp();
        }
        if(Input.GetKeyDown("s"))
        {
            GoDown();
        }

    }

    



    void GoRight()
    {
        if(i != 3 && i != 7 && i != 11 && i != 15)
            {
                i += 1;
                nextpoint = gametile.values[i].transform.position;
                playerposition.position = nextpoint;
            }
    }

    void GoLeft()
    {
         if(i != 0 && i != 4 && i != 8 && i != 12)
            {
                i -= 1;
                nextpoint = gametile.values[i].transform.position;
                playerposition.position = nextpoint;
            }
    }

    void GoDown()
    {
        if(i != 12 && i != 13 && i != 14 && i != 15)
            {
                i += 4;
                nextpoint = gametile.values[i].transform.position;
                playerposition.position = nextpoint;
            }
    }

    void GoUp()
    {
        if(i != 0 && i != 1 && i != 2 && i != 3)
            {
                i -= 4;
                nextpoint = gametile.values[i].transform.position;
                playerposition.position = nextpoint;
            }
    }
}
