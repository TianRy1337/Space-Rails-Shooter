using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBorad : MonoBehaviour
{
    public static ScoreBorad instance;
    
    
    private void Awake()
    {
        instance = this;
    }
    int score;
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreHit(int scoreIncrease)
    {
        score +=scoreIncrease;
        scoreText.text = score.ToString();
    }
}
