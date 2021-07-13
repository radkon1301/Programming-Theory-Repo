using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Keyboard inputs
    public float verticalInput;
    public float horizontalInput;

    public GameObject bulletPrefab;
    private GameManager gameManager;

    // Helicopter's speed
    private float speed = 10;

    // Helicopter's turn speed
    private float turnSpeed = 240;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.isGameOver)
        {
            ManageInput();
        }
    }

    private void ManageInput()
    {
        // Fire
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }

        // Get the inputs
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move helicopter
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        float h = Input.mousePosition.x - Screen.width / 2;
        float v = Input.mousePosition.y - Screen.height / 2;
        transform.LookAt(new Vector3(h, 0, v));
    }

    public void Kill()
    {
        gameManager.EndGame();
        Destroy(gameObject);
    }
}
