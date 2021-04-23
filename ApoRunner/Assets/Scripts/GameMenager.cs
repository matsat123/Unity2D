using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenager : MonoBehaviour
{

    public static GameMenager instance;
    public float worldScrollingSpeed = 0.2f;
    public float score;
    public Text scoreText;

    public GameObject obstacle;
    public float obstacleSpawRate;
    public float maxObstacleSpawnHeight;
    public float minObstacleSpawnHeight;
    public float obstacleSpawnPositionX;

    void Start()
    {
        instance = this;

        InvokeRepeating("SpawnObstacle", obstacleSpawRate, obstacleSpawRate);
    }

    void FixedUpdate()
    {
        score += worldScrollingSpeed;
        UpdateScreenScore();
    }

    void UpdateScreenScore()
    {
        scoreText.text = score.ToString("0");
    }

    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        var spawnPosition = new Vector3(obstacleSpawnPositionX, Random.Range(minObstacleSpawnHeight, maxObstacleSpawnHeight), 0f);
        Instantiate(obstacle, spawnPosition, Quaternion.identity);
    }
}
