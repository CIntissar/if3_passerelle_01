using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstComponent : MonoBehaviour
{
    
    public float rotationSpeed;
    public float moveSpeed;
    public Vector3 rotationAxis;
    public bool reverse;

    void Start()
    {
        Debug.Log("Hello World");
    }

    void Update()
    {   
        transform.Translate(moveSpeed*Time.deltaTime,0,0);

        
        if(!reverse)
        {
            transform.Rotate(rotationAxis*rotationSpeed*Time.deltaTime,Space.World);
        }
        else
        {
            transform.Rotate(rotationAxis*-rotationSpeed*Time.deltaTime,Space.World);
        }
        
    }

}
