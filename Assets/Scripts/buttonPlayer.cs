using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPlayer : MonoBehaviour
{
    public GameObject ActivatePhysicsObject;

    public string color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && other.gameObject.GetComponent<ColorScript>().color == color)
        {
            ActivatePhysicsObject.GetComponent<Rigidbody>().isKinematic = false;

            StartCoroutine(ActivatePhysicsObject.GetComponent<capsuleFall>().timerRewind());
        }
    }
}
