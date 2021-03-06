﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    // Audio stuff
    private AudioSource audioSource;
    public AudioClip patrick;
    public AudioClip response;
    bool voiced = false;

    private float timeRemaining = 29;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playPatrick();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            if (timeRemaining < 5 && voiced == false)
            {
                voiced = true;
                playFlat();
            }
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("Level_3");
        }
    }

    public void playPatrick()
    {
        audioSource.PlayOneShot(patrick);
    }
    public void playFlat()
    {
        audioSource.PlayOneShot(response);
    }
}
