using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Début de la partie du niveau "+ G.Level);
        Time.timeScale = 1.0f; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameData G;
}
