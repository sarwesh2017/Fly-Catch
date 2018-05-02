using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector3 offset;
    private float cameraFollowSpeed = 5f;

    
	

	void Update () {

        Vector3 newPositon = player.position + offset;

        transform.position = Vector3.Lerp(transform.position, newPositon, cameraFollowSpeed * Time.deltaTime);
		
	}
}
