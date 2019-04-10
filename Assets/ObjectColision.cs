using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColision : MonoBehaviour
{
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
        print(other);
    }

    private void OnCollisionEnter(Collision other)
    {
        print(other);
    }

}
