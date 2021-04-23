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

    void Start()
    {
        instance = this;
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
}
