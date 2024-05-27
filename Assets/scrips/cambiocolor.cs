using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiocolor : MonoBehaviour
{
    public Material shadermate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            shadermate.SetColor("_color", Random.ColorHSV()*30);
            shadermate.SetColor(" _emision", Random.ColorHSV() * 30);  
        }
    }
}
