using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public string wrongColor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && other.gameObject.GetComponent<ColorScript>().color != wrongColor)
        {
            gameObject.GetComponent<DialgoueTrigger>().TriggerDialogue();

        }
    }
}
