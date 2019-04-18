using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public static CanvasScript instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

    
    void Awake()
    {
        if (instance == null)          
            instance = this;   
        else if (instance != this)  
            Destroy(gameObject);          
        DontDestroyOnLoad(gameObject);
            
        //Get a component reference to the attached BoardManager script
   
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
