using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && other.gameObject.GetComponent<ColorScript>().color != "green")
        {
            gameObject.GetComponent<DialgoueTrigger>().TriggerDialogue();

        }
    }
}
