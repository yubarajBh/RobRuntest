using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
        public float pointsPerSecond;
        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI hiScoreText;
        public float score;
        private float hiScore;
        public bool isScoreIncreasing;
        void Start()
    {isScoreIncreasing= true;
        if(PlayerPrefs.HasKey("HighScore"))
        {
            hiScore= PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {   if(isScoreIncreasing)
        score+= pointsPerSecond*Time.deltaTime;
        if(score>hiScore){
            hiScore= score;
        PlayerPrefs.SetFloat("HighScore",hiScore);}

        scoreText.text = Mathf.Round(score).ToString();
        hiScoreText.text = Mathf.Round(hiScore).ToString();
    }
}
