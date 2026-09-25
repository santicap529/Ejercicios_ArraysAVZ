using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigosManager : MonoBehaviour
{
    public EnemigoScript[] enemies;
    
    // Start is called before the first frame update
    void Start()
    {
      enemies = FindObjectsOfType<EnemigoScript>();
      SetAllEnemiesDamagePointsTo(5);
      Debug.Log(enemies[enemies.Length-1].damagePoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetAllEnemiesDamagePointsTo(int value)
    {
      for(int i = 0 ; i < enemies.Length ; i++)
      {
         enemies[i].damagePoints = value;
      }
    }
}
