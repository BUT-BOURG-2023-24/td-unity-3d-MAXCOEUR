using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImpact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,1.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            GameManager.Instance.addKill();
            Destroy(enemy.gameObject);

            Debug.Log(GameManager.Instance.getKill() + " kill");
        }
    }
}
