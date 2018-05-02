using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour {
    [SerializeField]
    private GameObject flyPrefab;
    [SerializeField]
    private int totalFlyMinimum = 12;
    private float spawnArea = 23f;
    public static int totalFiles;

	
	void Start () {
        totalFiles = 0;
	}
	
	void Update () {
        
        while (totalFiles < totalFlyMinimum) {


            totalFiles++;

           

            float positionX = Random.Range(-spawnArea, spawnArea);
            float positionZ = Random.Range(-spawnArea, spawnArea);

            Vector3 flyPostion = new Vector3(positionX, 1f, positionZ);

           

            Instantiate(flyPrefab , flyPostion , Quaternion.identity);
        }
	}
}
