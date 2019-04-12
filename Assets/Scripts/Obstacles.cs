﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Obstacles : MonoBehaviour
{
    public string myColor;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Player").GetComponent<ColorScript>().color == myColor)
        {
            gameObject.GetComponent<NavMeshObstacle>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<NavMeshObstacle>().enabled = true;
        }
    }
}
