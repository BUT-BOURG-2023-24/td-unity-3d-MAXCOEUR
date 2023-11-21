using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DestroyCubeOnCollide : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            destroy();
        }
        
    } 

    private void destroy()
    {
        Destroy(gameObject);
    }
}
