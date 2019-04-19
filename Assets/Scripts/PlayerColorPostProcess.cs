using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorPostProcess : MonoBehaviour
{
    private ColorScript playerColor;

    private Light pointColor;

    private bool once = false;
    // Start is called before the first frame update
    void Start()
    {
        playerColor = gameObject.GetComponentInParent<ColorScript>();
        pointColor = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerColor.color == "" && !once)
        {
            pointColor.color = Color.Lerp(pointColor.color, new Color(1,0.54f,0), Mathf.PingPong(Time.time, 1));
            pointColor.intensity = 2;
            once = true;
        } else if (playerColor.color == "green")
        {
            pointColor.color = Color.Lerp(pointColor.color, Color.green,  Mathf.PingPong(Time.time, 1));
            pointColor.intensity = 3;
        } else if (playerColor.color == "red")
        {
            pointColor.color = Color.Lerp(pointColor.color, Color.red, Mathf.PingPong(Time.time, 1));
            pointColor.intensity = 3;
        }  else if (playerColor.color == "blue")
        {
            pointColor.color = Color.Lerp(pointColor.color, Color.blue, Mathf.PingPong(Time.time, 1));
            pointColor.intensity = 3;
        } else if (playerColor.color == "yellow")
        {
            pointColor.color = Color.Lerp(pointColor.color, Color.yellow, Mathf.PingPong(Time.time, 1));
            pointColor.intensity = 3;
        } else if (playerColor.color == "magenta")
        {
            pointColor.color = Color.Lerp(pointColor.color, Color.magenta, Mathf.PingPong(Time.time, 1));
            pointColor.intensity = 3;
        } else if (playerColor.color == "cyan")
        {
            pointColor.color = Color.Lerp(pointColor.color, Color.cyan, Mathf.PingPong(Time.time, 1));
            pointColor.intensity = 3;
        } else if (playerColor.color == "white")
        {
            pointColor.color = Color.Lerp(pointColor.color, Color.white, Mathf.PingPong(Time.time, 1));
            pointColor.intensity = 3;
        } 
    }
}
