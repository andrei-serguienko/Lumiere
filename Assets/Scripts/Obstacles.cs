using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Obstacles : MonoBehaviour
{
    public string myColor;

    public bool walkable = false;
    // Update is called once per frame
    void Update()
    {
        if (!walkable)
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
        else
        {
            if (GameObject.FindWithTag("Player").GetComponent<ColorScript>().color == myColor)
            {
                gameObject.GetComponent<NavMeshModifier>().area = 0;
            }
            else
            {
                gameObject.GetComponent<NavMeshModifier>().area = 1;
            }
        }
    }
}
