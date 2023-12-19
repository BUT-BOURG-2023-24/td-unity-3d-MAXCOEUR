using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5f;
    public Rigidbody rb;
    
    
    private Transform player;

    void Start()
    {
        GameObject playerGo = GameObject.FindGameObjectWithTag("Player");
        player = playerGo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerDirection = player.position-transform.position;

        rb.velocity = new Vector3(playerDirection.normalized.x * speed , rb.velocity.y, playerDirection.normalized.z * speed);

        Vector3 playerSameHeight = player.position;
        playerSameHeight.y = transform.position.y;
        transform.LookAt(playerSameHeight);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.Instance.ReloadGame();
        }
    }
}
