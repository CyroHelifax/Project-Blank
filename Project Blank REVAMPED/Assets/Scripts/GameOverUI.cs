using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    [SerializeField]
    private Text scoreValueText;
    [SerializeField]
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Health.OnPlayerDeath += ActivateGameObject;
        Debug.Log("Logged Start P1 (1/4)");
        Health.OnEnemyDeath += CountScore;
        this.gameObject.SetActive(false);
        Debug.Log("Logged Start P2 (1/4)");
    }

    void OnDestroy()
    {
        Health.OnPlayerDeath -= ActivateGameObject;
        Debug.Log("Logged Destroy P1 (2/4)");
        Health.OnEnemyDeath -= CountScore;
        Debug.Log("Logged Destroy P2 (2/4)");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void CountScore()
    {
        score++;
        Debug.Log("Score Changed (3/4)");
    }

    private void ActivateGameObject()
    {
        this.gameObject.SetActive(true);
        scoreValueText.text = score.ToString();
        Debug.Log("Score Displayed (4/4)");
    }

}