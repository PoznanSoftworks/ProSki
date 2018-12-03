using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour {

    private float spawnZ = 0.0f;
    private float spawnY = 1.0f;
    private float length = 17.35881165388336f;
    private float down = -10.5f;
    private int maximumNumberOFCoins = 5;
    private List<int> listOfPositions = new List<int>();


    private Transform playerTransform;
    public GameObject prefabCoin;
    public List<GameObject> listOfCoins = new List<GameObject>();


    bool CheckIfCoindIsUse(GameObject Coin)
    {
        return !Coin.activeInHierarchy;
    }


    void CreatCoinsInFromOfPlayer()
    {
        for (int i = 0; i < Random.Range(1, maximumNumberOFCoins); i++)
        {
            GameObject newCoin;
            newCoin = Instantiate(prefabCoin) as GameObject;
            newCoin.transform.SetParent(transform);
            int randomPosition = Random.Range(-5, 5);
            foreach (int pos in listOfPositions)
            {
                if (pos != randomPosition)
                {
                    newCoin.transform.position = new Vector3(randomPosition, spawnY, spawnZ);
                }
            }


            listOfPositions.Add(randomPosition);
            listOfCoins.Add(newCoin);
        }
        listOfCoins.Clear();
        spawnZ += length;
        spawnY += down;
    }


    void DeactiveCoin(GameObject coin)
    {
        coin.SetActive(false);
    }


    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < 5; i++)
        {
            CreatCoinsInFromOfPlayer();
        }
    }


    void Update()
    {

        if (playerTransform.position.z > (spawnZ - length))
        {
            for (int i = 0; i < 3; i++)
            {
                CreatCoinsInFromOfPlayer();
            }
        }

    }

}
