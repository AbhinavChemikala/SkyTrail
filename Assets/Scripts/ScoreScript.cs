using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score;
    public TextMeshProUGUI highScoreText;
    private float highscore = 0f;
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
        highScoreText.text = "High Score - " + highscore.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        score += 0.1f;
        scoreText.text = "Score - " + score.ToString("0");
        if (highscore < score)
        {
            PlayerPrefs.SetFloat("highscore",score);
        }
    }
}
