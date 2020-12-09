using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawner : MonoBehaviour
{
    private Vector3 Min;
    private Vector3 Max;
    private float _xAxis;
    private float _yAxis;
    private float _zAxis; //If you need this, use it
    private Vector3 _randomPosition;
    public bool _canInstantiateBox;
    public bool _canInstantiateGlobe;

    public GameObject fallingBox;
    public GameObject globe;
    float elapsed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        SetRanges();
        //InvokeRepeating("InstantiateRandomObjects", 1f, 1f);

        //Instantiate(fallingBox, new Vector3(8, 16, 8), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
        _zAxis = UnityEngine.Random.Range(Min.z, Max.z);

        _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);

        //int RandomInt = Random.Next(0, 2);
        //RandomInt.Next(0, 2);
        var number = Random.Range(0, 2);


        elapsed += Time.deltaTime;
        if (number == 1)
        {

            //Debug.Log(number);
            if (elapsed >= 1f)
            {
                _canInstantiateBox = true;
                elapsed = elapsed % 1f;
                //Debug.Log(RandomInt);
                InstantiateRandomObjects();

            }
        }


        if(number == 0)
        {
            //Debug.Log(number);
            if (elapsed >= 1f)
            {
                _canInstantiateGlobe = true;
                elapsed = elapsed % 1f;
                //Debug.Log(RandomInt);
                InstantiateRandomObjectsGlobe();
            }
        }


   
        
        

    }

    private void SetRanges()
    {

        Min = new Vector3(-8, 16, -3); //Random value.
        Max = new Vector3(8, 18, 10); //Another ramdon value, just for the example.
        //Debug.Log(Min);
        //Debug.Log(Max);
    }

    private void InstantiateRandomObjects()
    {
        if (_canInstantiateBox)
        {
            Instantiate(fallingBox, _randomPosition, Quaternion.identity);
            _canInstantiateBox = false;
            //Debug.Log(_randomPosition);
        }

    }
    private void InstantiateRandomObjectsGlobe()
    {
        if (_canInstantiateGlobe)
        {
            Instantiate(globe, _randomPosition, Quaternion.identity);
            _canInstantiateGlobe = false;
            Debug.Log(_randomPosition);
        }

    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);
        _canInstantiateBox = true;
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        InstantiateRandomObjects();
    }
}
