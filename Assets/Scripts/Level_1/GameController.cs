using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI question;
    public TextMeshProUGUI response;
    bool answerOne = false;
    bool answerTwo = false;
    bool answerThree = false;
    // Clicking Object
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        questionOne();
        response.text = "Thinking....";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            target = ReturnClickedObject(out hitInfo);
            // First Answer
            if (target != null && target.name == "Cube" && answerOne == false)
            {
                answerOne = true;
                questionTwo();
                responseOne();
            }
            // Third Answer
            if (target != null && target.name == "Cylinder" && answerThree == false && answerTwo == true)
            {
                answerThree = true;
                //questionsDone();
                responseThree();
                SceneManager.LoadScene("Level_2");
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // Second Answer
            if (target != null && target.name == "Sphere" && answerOne == true && answerTwo == false && (target.transform.position.x > 3 || target.transform.position.x < -3))
            {
                answerTwo = true;
                questionThree();
                responseTwo();
            }
        }
    }


    // Questions for player
    void questionOne()
    {
        question.text = "What is the true shape of our world?";
    }

    void questionTwo()
    {
        question.text = "Does gravity exist?";
    }

    void questionThree()
    {
        question.text = "What other sign points to the truth?";
    }
    void questionsDone()
    {
        question.text = "...................................";
    }
    // Character responses
    void responseOne()
    {
        response.text = "Flat of course!";
    }
    void responseTwo()
    {
        response.text = "It did not fall, gravity is fake news!";
    }
    void responseThree()
    {
        response.text = "There is always a sign.";
    }

    GameObject ReturnClickedObject(out RaycastHit hit)
    {
        GameObject targetObject = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            targetObject = hit.collider.gameObject;
        }
        return targetObject;
    }


}
