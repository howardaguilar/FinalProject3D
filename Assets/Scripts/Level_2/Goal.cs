﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Purse remaining;
    // Start is called before the first frame update
    void Start()
    {
        remaining = GameObject.Find("Purse").GetComponent<Purse>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sphere")
        {
            remaining.minusCounter();
            Destroy(other.gameObject);
        }
    }
}
