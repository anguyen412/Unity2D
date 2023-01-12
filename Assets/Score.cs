using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public PipeSpawner p;
    private int currentScore = 0;
    private float timeToSpawn = 4.429f;
    
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn) {
            currentScore++;
            timeToSpawn = Time.time + p.timeBetweenWaves;
        }
        scoreText.SetText(currentScore.ToString());
    }
}
