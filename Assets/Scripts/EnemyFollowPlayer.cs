using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollowPlayer : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").transform;

        //if (player != null)
          //  Debug.LogError("Player Not Found");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
}
