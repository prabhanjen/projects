using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
public class TextController : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateScoreText();

    }

    private void UpdateScoreText()
    {
        
        scoreText.text = "score: "+score.ToString();
        //Thread.Sleep(650);
        score+=1;
    }

}