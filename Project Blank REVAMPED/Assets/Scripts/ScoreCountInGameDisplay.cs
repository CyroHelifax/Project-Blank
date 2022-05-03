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

    void Start()
    {
        Health.OnEnemyDeath += CountScore;
        this.gameObject.SetActive(false);
        // Debug.Log("Logged Start (1/4)");
    }

    void OnDestroy()
    {
        Health.OnEnemyDeath -= CountScore;
        // Debug.Log("Logged Destroy P2 (2/4)");
    }

    private void CountScore()
    {
        score++;
    }

    private void ActivateGameObject()
    {
        this.gameObject.SetActive(true);
        scoreValueText.text = score.ToString();
        // Debug.Log("Score Displayed (4/4)");
    }

}
