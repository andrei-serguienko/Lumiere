using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCameraPlace : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
           anim.SetTrigger("changePlace"); 
        }
    }
}
