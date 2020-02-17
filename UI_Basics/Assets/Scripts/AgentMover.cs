using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMover : MonoBehaviour
{
    // variables
    [Header("Navigation Components")]
    public NavMeshAgent agent;
    public Transform moveTarget;
    public float defaultMoveSpeed = 10;

    public bool doMoveAtDoubleSpeed;
    public int myInteger = -50;
    public float myFloat = 4.5f;
    public string myString = "hello world";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(moveTarget.position);

        if (doMoveAtDoubleSpeed == true)
        {
            // code that executes ONLY IF conditional is TRUE
            agent.speed = defaultMoveSpeed * 2;
        }
        else
        {
            agent.speed = defaultMoveSpeed;
        }
    }
}
