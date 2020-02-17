using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMotor : MonoBehaviour
{
    // variables
    [Header("Navigation Components")]
    public NavMeshAgent agent;
    public Transform moveTarget;
    public float defaultMoveSpeed = 10;

    public bool reducingSpeed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(moveTarget.position);

        if (reducingSpeed == true)
        {
            // code that executes ONLY IF conditional is TRUE
            agent.speed -= 0.005f ;
        }
        else
        {
            agent.speed = defaultMoveSpeed;
        }
    }
}
