﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour {

    [SerializeField]
    private Transform target;
    private UnityEngine.AI.NavMeshAgent birdAgent;
    private Animator birdAnimator;
    [SerializeField]
    private RandomSoundPlayer birdFootsteps;


	
	void Start () {
        birdAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        birdAnimator = GetComponent<Animator>();

	}
	
	
	void Update () {
       

        birdAgent.SetDestination(target.position);

        

        float speed = birdAgent.velocity.magnitude;
 
        birdAnimator.SetFloat("Speed", speed);

        if (speed > 0)
        {

            birdFootsteps.enabled = true;
        }
        else {

            birdFootsteps.enabled = false;
        }



	}
}
