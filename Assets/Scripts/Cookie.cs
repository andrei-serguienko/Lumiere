using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Cookie : MonoBehaviour
{
    public string cookieColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            other.GetComponent<ColorScript>().addColor(cookieColor);
            Destroy(gameObject);
        }
    }
}
