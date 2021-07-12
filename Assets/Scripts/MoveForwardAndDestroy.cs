using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardAndDestroy : MonoBehaviour
{
    public float speed = 40.0f;
    private float maxDistance = 60.0f;
    private float distanceTraveled = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = speed * Time.deltaTime;
        transform.Translate(Vector3.forward * dist);
        distanceTraveled += dist;
        if (distanceTraveled > maxDistance)
        {
            Destroy(gameObject);
        }
    }
}
