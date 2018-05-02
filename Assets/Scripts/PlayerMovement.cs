using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Animator playerAnimator;
    private float moveHorizontal;
    private float moveVertical;
    private Vector3 movement;
    private float turningSpeed = 20f;
    private Rigidbody playerRigidbody;
    [SerializeField]
    private RandomSoundPlayer playerFootsteps;

	// Use this for initialization
	void Start () {
        // Gather the Animator component from the Player GameObject
        playerAnimator = GetComponent<Animator>();

        playerRigidbody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
	}

    void FixedUpdate() {

        // if player movement vector does not equal zero...
        if (movement != Vector3.zero) {

            // .. then create a target rotation based on the movement vector..
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);

            // ... then create another rotation that move from the current rotaion to the target rotation..
            Quaternion newRotation = Quaternion.Lerp(playerRigidbody.rotation, targetRotation , turningSpeed * Time.deltaTime);

            // ... and tchange the players rotation to the increment rotaion...

            playerRigidbody.MoveRotation(newRotation);

        //... then play the jump animation.
            playerAnimator.SetFloat("Speed", 3f);

            // .... play footsteps sound
            playerFootsteps.enabled = true;

        }
        else {
            // dont play the jump animation.
            playerAnimator.SetFloat("Speed", 0f);

            playerFootsteps.enabled = false;
        }

    }


}
