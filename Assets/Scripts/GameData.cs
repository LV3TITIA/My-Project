using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenuAttribute]
public class GameData : ScriptableObject
{
    public int Level;

    //Quand l'instance est crée
    public void Awake()
    {
        Level = 0;
    }

    private void OnEnable()
    {
        Level +=1;
    }
}
