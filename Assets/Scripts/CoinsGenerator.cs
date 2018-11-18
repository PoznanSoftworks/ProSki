using UnityEngine;

public class CoinsGenerator : MonoBehaviour {


    public float rotation;
    public float distanceBetweenObstacles;
    float lastYPos;


    public GameObject mountainPrefab;

    public Transform playerTransform;
    public Transform obstaclePrefab;


    void Start()
    {
        lastYPos = Mathf.NegativeInfinity;

    }


    void Update()
    {
    }





}
