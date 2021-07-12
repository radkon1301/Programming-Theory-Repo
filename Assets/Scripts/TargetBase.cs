using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBase : MonoBehaviour
{
    public GameObject targetBase;
    public float speed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetBase.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
