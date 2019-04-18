using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateChangeColor : MonoBehaviour
{
    public string colorToAdd;
    
    public GameObject bridge1;
    public GameObject bridge2;
    public GameObject bridge3;
    public GameObject bridge4;
    public GameObject bridge5;
  

    private void OnCollisionEnter(Collision other)
    {
        bridge1.GetComponent<ColorScript>().addColor(colorToAdd);
        bridge2.GetComponent<ColorScript>().addColor(colorToAdd);
        bridge3.GetComponent<ColorScript>().addColor(colorToAdd);
        bridge4.GetComponent<ColorScript>().addColor(colorToAdd);
        bridge5.GetComponent<ColorScript>().addColor(colorToAdd);
    }
}
