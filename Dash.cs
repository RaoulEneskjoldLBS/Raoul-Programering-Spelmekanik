using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector3(10, 0, 0), ForceMode.Impulse);
        }
    }
}
