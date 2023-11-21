using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = Vector3.zero;
    void LateUpdate()
    {
        if (player != null)
        {
            // Faire en sorte que la caméra regarde toujours le joueur
            Vector3 position = player.transform.position+ offset;
            transform.position = position;
            transform.LookAt(player.transform);
        }
        else
        {
            Debug.LogWarning("Player non assigné à la caméra fixe.");
        }
    }
}
