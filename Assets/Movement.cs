using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    Rigidbody rb;



    bool cd2;

   [SerializeField] float cddter;


    float keypresses;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        cd2 = true;

        keypresses = 0;

       
    }

    // Update is called once per frame
    void Update()
    {

       
      


        





        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(4, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-4, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.Space) && keypresses < 1)
        {

            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);

            Console.WriteLine("Jumping");

            keypresses += 1;

            
        }


        if (Input.GetKeyDown(KeyCode.Space) && cd2 && keypresses < 1 ) 
        {

            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);

            Console.WriteLine("Double jumping");

            keypresses += 1;

            StartCoroutine("cd"); 

           

           
        }



        if (rb.position.y < 1 )
        {
            keypresses = 0; 
        }


        
    }



    IEnumerator cd()
    {
        cd2 = false;



        yield return new WaitForSeconds(cddter);

        cd2 = true;
    }



}
