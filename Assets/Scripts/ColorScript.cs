using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public float removeColorDelay;
    public string color;

    public Material noColor;
    
    public Material red;
    public Material green;
    public Material blue;
    
    public Material cyan;
    public Material magenta;
    public Material yellow;
    
    public Material white;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool addColor(string color)
    {
        if (this.color == "" || this.color == "white")
        {
            this.color = color;
            switch (color)
            {
                case "red":
                    gameObject.GetComponent<MeshRenderer>().material = red;
                break;
                case "green":
                    gameObject.GetComponent<MeshRenderer>().material = green;
                break;
                case "blue":
                    gameObject.GetComponent<MeshRenderer>().material = blue;
                break;
            }

            //StartCoroutine(removeColor(color));
            return true;
        } else if (this.color == "red")
        {
            switch (color)
            {
                case "red":
                    return false;
                    break;
                case "green":
                    gameObject.GetComponent<MeshRenderer>().material = yellow;
                    this.color = "yellow";
                    break;
                case "blue":
                    gameObject.GetComponent<MeshRenderer>().material = magenta;
                    this.color = "magenta";
                    break;
            }
            //StartCoroutine(removeColor(color));
            return true;
        }else if (this.color == "blue")
        {
            switch (color)
            {
                case "red":
                    gameObject.GetComponent<MeshRenderer>().material = magenta;
                    this.color = "magenta";
                    break;
                case "green":
                    gameObject.GetComponent<MeshRenderer>().material = cyan;
                    this.color = "cyan";
                    break;
                case "blue":
                    return false;
                    break;
            }
            //StartCoroutine(removeColor(color));
            return true;
        }else if (this.color == "green")
        {
            switch (color)
            {
                case "red":
                    gameObject.GetComponent<MeshRenderer>().material = yellow;
                    this.color = "yellow";
                    break;
                case "green":
                    return false;
                    break;
                case "blue":
                    gameObject.GetComponent<MeshRenderer>().material = cyan;
                    this.color = "cyan";
                    break;
            }
            //StartCoroutine(removeColor(color));
            return true;
        }else if (this.color == "cyan")
        {
            if (color == "red")
            {
                this.color = "white";
                gameObject.GetComponent<MeshRenderer>().material = white;
                //StartCoroutine(removeColor(color));
                return true;
            }

            return false;
        }else if (this.color == "yellow")
        {
            if (color == "blue")
            {
                this.color = "white";
                gameObject.GetComponent<MeshRenderer>().material = white;
                //StartCoroutine(removeColor(color));
                return true;
            }

            return false;
        }else if (this.color == "magenta")
        {
            if (color == "green")
            {
                this.color = "white";
                gameObject.GetComponent<MeshRenderer>().material = white;
                //StartCoroutine(removeColor(color));
                return true;
            }

            return false;
        }

        return false;
    }

    IEnumerator removeColor(string color)
    {
        yield return new WaitForSeconds(removeColorDelay);
        switch (this.color)
        {
            case "red":
                if (color == "red")
                {
                    gameObject.GetComponent<MeshRenderer>().material = noColor;
                    this.color = "";
                }
                break;
            case "green":
                if (color == "green")
                {
                    gameObject.GetComponent<MeshRenderer>().material = noColor;
                    this.color = "";
                }
                break;
            case "blue":
                if (color == "blue")
                {
                    gameObject.GetComponent<MeshRenderer>().material = noColor;
                    this.color = "";
                }
                break;
            case "cyan":
                if (color == "green")
                {
                    gameObject.GetComponent<MeshRenderer>().material = blue;
                    this.color = "blue";
                }else if (color == "blue")
                {
                    gameObject.GetComponent<MeshRenderer>().material = green;
                    this.color = "green";
                }
                break;
            case "magenta":
                if (color == "red")
                {
                    gameObject.GetComponent<MeshRenderer>().material = blue;
                    this.color = "blue";
                } else if (color == "blue")
                {
                    gameObject.GetComponent<MeshRenderer>().material = red;
                    this.color = "red";
                }
                break;
            case "yellow":
                if (color == "red")
                {
                    gameObject.GetComponent<MeshRenderer>().material = green;
                    this.color = "green";
                } else if (color == "green")
                {
                    gameObject.GetComponent<MeshRenderer>().material = red;
                    this.color = "red";
                }
                break;
            case "white":
                if (color == "red")
                {
                    gameObject.GetComponent<MeshRenderer>().material = cyan;
                    this.color = "cyan";
                } else if (color == "green")
                {
                    gameObject.GetComponent<MeshRenderer>().material = magenta;
                    this.color = "magenta";
                } else if (color == "blue")
                {
                    gameObject.GetComponent<MeshRenderer>().material = yellow;
                    this.color = "yellow";
                }
                break;
        }
    }
}
