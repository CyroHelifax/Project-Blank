using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCountInGameDisplay : MonoBehaviour
{
    [SerializeField]
    private Text scoreValueText;
    [SerializeField]
    private int score = 0;

    void Update()
    {
        Health.OnEnemyDeath += CountScore;
        scoreValueText.text = score.ToString();
    }

    public void CountScore()
    {
        score++;
    }

}
