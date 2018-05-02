using System.Collections;
using System.Collections.Generic;



using UnityEngine;



public class RandomSoundPlayer : MonoBehaviour {

    private AudioSource audioSource;
    [SerializeField]
    private List<AudioClip> soundClip = new List<AudioClip>();
    [SerializeField]
    private float soundTimerDelay = 3f;
    private float soundTimer;



	
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	
	void Update () {
        soundTimer = soundTimer + Time.deltaTime;

        if (soundTimer >= soundTimerDelay) {
            

            soundTimer = 0f;

           

            AudioClip randomSound = soundClip[Random.Range (0, soundClip.Count)];

          

            audioSource.PlayOneShot(randomSound);

        }




	}
}
