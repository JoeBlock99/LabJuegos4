using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    public GameObject capsula;
    // Start is called before the first frame update
    void Start()
    {
        capsula.transform.GetComponent<Renderer>().material.shader = Shader.Find("Transparent/Diffuse");
        capsula.transform.GetComponent<Renderer>().material.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
