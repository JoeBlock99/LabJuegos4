using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tapp : MonoBehaviour
{
    public Rigidbody rb;
    public int force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseOver()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
    private void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo))
        {
            rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
        }
    }
}
