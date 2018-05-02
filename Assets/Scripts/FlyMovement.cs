using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour {

    [SerializeField]
    private Transform center;
    private float flySpeed;


	
	void Start () {
        flySpeed = Random.Range(300f, 700f);
	}
	
	void Update () {
        transform.RotateAround(center.position , Vector3.up, flySpeed * Time.deltaTime);
	}
}
