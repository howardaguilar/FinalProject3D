using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI life;

    private int scorecount = 0;
    private int lifecount = 3;

    // Start is called before the first frame update
    void Start()
    {

        UpdateScore();
        UpdateLife();
    }

    // Update is called once per frame
    void Update()
    {
        if(scorecount >= 5)
        {
            SceneManager.LoadScene("YouWin");
        }
        if(lifecount <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void UpdateScore()
    {
        score.text = "Score: " + scorecount.ToString();
    }

    public void UpdateLife()
    {
        life.text = "Life: " + lifecount.ToString();
    }
    public void IncrementScore()
    {
        scorecount += 1;
    }
    public void DecrementLife()
    {
        lifecount -= 1;
    }

  
}
