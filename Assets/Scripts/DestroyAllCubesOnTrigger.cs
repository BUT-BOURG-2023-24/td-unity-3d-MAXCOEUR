using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DestroyAllCubesOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject[] list = GameObject.FindGameObjectsWithTag("Cube");
            foreach (GameObject go in list)
            {
                Destroy(go);
            }
        }
    }
}
