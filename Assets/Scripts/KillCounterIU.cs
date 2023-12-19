using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillCounterIU : MonoBehaviour
{
    public TextMeshProUGUI textView;
    void Start()
    {
        textView.text =$"Kill : { GameManager.Instance.getKill()}";
    }

    // Update is called once per frame
    void Update()
    {
        textView.text = $"Kill : {GameManager.Instance.getKill()}";
    }
}
