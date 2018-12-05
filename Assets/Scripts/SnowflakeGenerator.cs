using System.Collections.Generic;
using UnityEngine;

public class SnowflakeGenerator : MonoBehaviour
{
    private float spawnZ = 0.0f;
    private float spawnY = 1.0f;
    private float length = 17.35881165388336f;
    private float down = -10.5f;
    private int maximumNumberOFSnowflakes = 5;
    private List<int> listOfPositions = new List<int>();

    private Transform playerTransform;
    public GameObject prefabSnowflake;
    public List<GameObject> listOfSnowflakes = new List<GameObject>();

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < 5; i++)
        {
            CreatSnowflakesInFrontOfPlayer();
        }
    }

    private void Update()
    {
        if (playerTransform.position.z > (spawnZ - length))
        {
            for (int i = 0; i < 3; i++)
            {
                CreatSnowflakesInFrontOfPlayer();
            }
        }
    }

    private void CreatSnowflakesInFrontOfPlayer()
    {
        for (int i = 0; i < Random.Range(1, maximumNumberOFSnowflakes); i++)
        {
            GameObject newSnowflake;
            newSnowflake = Instantiate(prefabSnowflake) as GameObject;
            newSnowflake.transform.SetParent(transform);
            int randomPosition = Random.Range(-5, 5);
            foreach (int pos in listOfPositions)
            {
                if (pos != randomPosition)
                {
                    newSnowflake.transform.position = new Vector3(randomPosition, spawnY, spawnZ);
                }
            }

            listOfPositions.Add(randomPosition);
            listOfSnowflakes.Add(newSnowflake);
        }
        listOfSnowflakes.Clear();
        spawnZ += length;
        spawnY += down;
    }

    private bool CheckIfSnowflakedIsUse(GameObject Snowflake)
    {
        return !Snowflake.activeInHierarchy;
    }

    private void DeactiveSnowflake(GameObject coin)
    {
        coin.SetActive(false);
    }
}