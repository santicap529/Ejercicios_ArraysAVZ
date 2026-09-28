using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    NavMeshAgent agent;
    Transform Destination;
    public bool isMaster;
    // Start is called before the first frame update
    void Start()
    {
       agent = GetComponent<NavMeshAgent>();
       if(isMaster)
       {
        Destination = FindObjectOfType<CharacterController>().transform;
       }
       else
       {
        Destination = GameObject.FindGameObjectWithTag("Master").transform;
       }
      
    }

    // Update is called once per frame
    void Update()
    {
       agent.destination = Destination.position; 
    }
}
