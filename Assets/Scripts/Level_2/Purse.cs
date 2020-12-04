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
    private int counter = 3;
    // Start is called before the first frame update
    void Start()
    {
        remaining.text = "Remaining: " + counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (counter <= 0)
        {
            transition();
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
        SceneManager.LoadScene("Level_3");
    }
}
