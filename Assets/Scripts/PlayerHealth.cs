﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public bool alive;
    [SerializeField]
    private GameObject pickupPrefab;

	
	void Start () {
        alive = true;
	}

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")   &&  alive == true) {
            alive = false;

            
            Instantiate(pickupPrefab, transform.position, Quaternion.identity);


        }

    }
}
