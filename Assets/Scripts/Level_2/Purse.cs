using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class Purse : MonoBehaviour
{
    public TextMeshProUGUI instructions;
    public TextMeshProUGUI response;
    public TextMeshProUGUI remaining;
    public TextMeshProUGUI time;
    private int counter = 3;
    private int fails = 0;
    private float timeRemaining = 60;
    // Start is called before the first frame update
    void Start()
    {
        remaining.text = "Remaining: " + counter.ToString();
        time.text = "Time: 60";
    }

    // Update is called once per frame
    void Update()
    {
        if (counter <= 0)
        {
            transition();
        }
        if (fails == 1)
        {
            response.text = "I shouldn't push them off the world.";
            fails++;
        }
        if (fails == 3)
        {
            response.text = "Maybe I should quit...";
            fails++;
        }
        if (fails > 4)
        {
            failTransition();
        }
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            updateTimer();
        } else
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void minusCounter()
    {
        counter = counter - 1;
        updateRemaining();
    }

    private void updateRemaining()
    {
        remaining.text = "Remaining: " + counter.ToString();
    }

    private void transition()
    {
        SceneManager.LoadScene("TransitionTwo");
    }

    public void updateFails()
    {
        fails++;
    }

    private void failTransition()
    {
        SceneManager.LoadScene("GameOver");
    }

    private void updateTimer()
    {
        time.text = "Time: " + timeRemaining.ToString();
    }
}
