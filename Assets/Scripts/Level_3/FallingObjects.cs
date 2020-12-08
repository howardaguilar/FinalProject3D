using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjects : MonoBehaviour
{
    public float fallSpeed = 8.0f;
    public float spinSpeed = 250.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
    }

  
    

}
