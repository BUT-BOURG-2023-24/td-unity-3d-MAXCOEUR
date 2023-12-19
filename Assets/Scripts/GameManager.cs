using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    private int _nbrKill = 0;
    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void addKill()
    {
        _nbrKill++;
    }
    public int getKill()
    {
        return _nbrKill;
    }

}


public abstract class Singleton<T>: MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get { return _instance; } }
    private static T _instance;

    public void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
        }
        else
        {
            Debug.LogError($"existe une instande de {GetType()} ! destruction de l'objet");
            Destroy(gameObject);
        }
    }
}