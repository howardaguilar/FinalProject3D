using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button retry;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = retry.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        StartCoroutine(ExampleCoroutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        SceneManager.LoadScene("Level_3");
    }

    void TaskOnClick()
    {
        //Debug.Log("Switching Scenes");
        //DontDestroyOnLoad(gameManager);
        SceneManager.LoadScene("Intro");

    }
}