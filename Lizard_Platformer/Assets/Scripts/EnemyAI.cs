﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform player;
    
   
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        agent.destination = player.position;
    }
    private void OnTriggerExit(Collider other)
    {
        agent.destination = agent.nextPosition;
    }
}
