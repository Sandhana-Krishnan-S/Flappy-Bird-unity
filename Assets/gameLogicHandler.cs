using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameLogicHandler : MonoBehaviour {
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("add score")]
    public void addScore(int valuToBeAdded) {
        score = score + valuToBeAdded;
        scoreText.text = score.ToString();
        Console.WriteLine(scoreText.text);
    }

    public void gameRestart() {
        score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }
}
