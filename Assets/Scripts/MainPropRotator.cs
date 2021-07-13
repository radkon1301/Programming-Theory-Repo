using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPropRotator : MonoBehaviour
{
    protected float rotationSpeed = 720.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateProp();
    }

    protected void RotateProp()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
