using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessMountain : MonoBehaviour {



    public GameObject[] mountainPrefabs;

    private Transform playerTransform;

    private float spawnZ = 0.0f;
    private float spawnY = 0.0f;
    private float length = 17.35881165388336f;
    private float down = -10.05f;
    private int ammountOfMountainsTiles = 5;


	// Use this for initialization
	void Start () {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
        for (int i =0; i < ammountOfMountainsTiles; i++)
        {
            SpawnMounatin();
        }

    }
	
	// Update is called once per frame
	void Update () {
		if(playerTransform.position.z > (spawnZ - ammountOfMountainsTiles * length))
        {
            SpawnMounatin();
        }
	}

    void SpawnMounatin(int mountainPrefabsIndex = -1  )
    {
        GameObject newMountain;
        newMountain = Instantiate(mountainPrefabs[0]) as GameObject;
        newMountain.transform.SetParent(transform);
        
        newMountain.transform.position = new Vector3(0, spawnY, spawnZ);
        spawnZ += length;
        spawnY += down;
    }

}
