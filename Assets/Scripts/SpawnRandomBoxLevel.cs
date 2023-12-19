using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public BoxCollider levelBox;
    private float timer = 0f;
    public float countdownTime = 10f; // Set your desired countdown time in seconds

    public GameObject prefabToCube;

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Check if the timer has reached the countdown time
        if (timer >= countdownTime)
        {
            // Timer has elapsed, do something here
            float x = Random.Range(levelBox.bounds.min.x, levelBox.bounds.max.x);
            float y = Random.Range(levelBox.bounds.min.y, levelBox.bounds.max.y);


            Vector3 spawnPoint = new Vector3 (x, 2, y);
            GameObject instance = Instantiate(prefabToCube, spawnPoint, Quaternion.identity);
            timer = 0f;
        }
    }
}
