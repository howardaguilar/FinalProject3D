using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    private float speed = 20.0f;

    public void Update()
    {
        if (prefabToInstantiate == null)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            GameObject newGameObject = (GameObject)Instantiate(prefabToInstantiate, mouseRay.origin, Quaternion.identity);
            Rigidbody rb = newGameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.velocity = mouseRay.direction * speed;
                Object.Destroy(newGameObject, 2.0f);
            }
        }
    }
}
