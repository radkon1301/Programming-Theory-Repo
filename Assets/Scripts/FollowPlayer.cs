using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Player to follow
    public GameObject player;

    // Offset for the camera
    private Vector3 offset = new Vector3(0, 50, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Follow the player
        transform.position = player.transform.position + offset;

        // Optional code to turn the camera to face the same way as the player
        //transform.SetPositionAndRotation(transform.position, player.transform.rotation);
        //transform.Rotate(new Vector3(90, 0, 0));
    }
}
