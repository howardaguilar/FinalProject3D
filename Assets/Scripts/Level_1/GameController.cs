using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI question;
    bool answerOne = false;
    bool answerTwo = false;
    bool answerThree = false;
    // Clicking Object
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        questionOne();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            target = ReturnClickedObject(out hitInfo);
            if (target != null && target.name == "Cube" && answerOne == false)
            {
                answerOne = true;
                questionTwo();
            }
            else if (target != null && target.name == "Cube" && answerOne == true && answerTwo == false)
            {
                answerTwo = true;
                questionThree();
            }
        }
    }

    void questionOne()
    {
        question.text = "What is the true shape of our world?";
    }

    void questionTwo()
    {
        question.text = "Is gravity really there?";
    }

    void questionThree()
    {
        question.text = "It's all flat....";
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
