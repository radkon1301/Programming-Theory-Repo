using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
    private GameObject player;
    public ParticleSystem explosion;
    private GameManager gameManager;
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        if (!gameManager.isGameOver)
        {
            transform.LookAt(player.transform.position);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Explode();
            player.GetComponent<PlayerController>().Kill();
        }
        else if (other.gameObject.CompareTag("Bullet"))
        {
            Explode();
            Destroy(other.gameObject);
        }
    }

    private void Explode()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
