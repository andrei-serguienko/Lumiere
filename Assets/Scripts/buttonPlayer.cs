using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPlayer : MonoBehaviour
{
    public GameObject ActivatePhysicsObject;

    public string color;

    private bool canPress = true;
    
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
        if (other.gameObject.name == "Player" && other.gameObject.GetComponent<ColorScript>().color == color && canPress)
        {
            StartCoroutine(delay());
            canPress = false;
            ActivatePhysicsObject.GetComponent<Rigidbody>().isKinematic = false;

            StartCoroutine(ActivatePhysicsObject.GetComponent<capsuleFall>().timerRewind());
        } else if (color == "All" && canPress)
        {
            StartCoroutine(delay());
            canPress = false;
            ActivatePhysicsObject.GetComponent<Rigidbody>().isKinematic = false;

            StartCoroutine(ActivatePhysicsObject.GetComponent<capsuleFall>().timerRewind());
        }
    }

    private IEnumerator delay()
    {
        yield return new WaitForSeconds(10f);
        canPress = true;
    }
}
