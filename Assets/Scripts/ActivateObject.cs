using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    public GameObject EnableObject;

    public string colorDifferentToActivate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Capsule")
            EnableObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && other.gameObject.GetComponent<ColorScript>().color != colorDifferentToActivate)
        {
            EnableObject.SetActive(true);
        }
    }
}
