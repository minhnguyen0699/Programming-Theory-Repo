using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private VehicleControl vehicleX;
    
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI gameOverScoreText;
    public bool isGameOver;
    private int score;
    public Image healthBar;
    private float maxHealth = 100f;
    public GameObject gameOverScreen;
    public GameObject ingameUI;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        vehicleX = GameObject.Find("RallyCar").GetComponent<VehicleControl>();
        score = 0;
        InvokeRepeating("UpdateScore", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = vehicleX.healthControl / maxHealth;
        if (vehicleX.healthControl <= 0)
        {
            isGameOver = true;
            GameOver();
        }
        scoreText.SetText("Score: " + score);

    }

    void UpdateScore()
    {
        if (!isGameOver) { score += 5; }
    }
    public void GameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
        ingameUI.gameObject.SetActive(false);
        gameOverScoreText.SetText("Score: " + score);
    }
}
