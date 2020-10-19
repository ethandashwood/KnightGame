using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove2 : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {







        float xSpeed = 1.0f;
        float ySpeed = -1.0f;
        if (Input.GetKey("a"))
        {
            // registers a key held down and returns true
            xSpeed = -5.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("d"))
        {
            // registers a key held down and returns true

            xSpeed = 5.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("s"))
        {
            // registers a key held down and returns true

            ySpeed = -5.0f;
            transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);


        }

        if (Input.GetKey("w"))
        {
            // registers a key held down and returns true

            ySpeed = 5.0f;
            transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);

            {

                if (Input.GetKey("a"))
                {

                    xSpeed = -2.0f;
                    transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);

                }

                if (Input.GetKey("d"))
                {

                    xSpeed = 2.0f;
                    transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);

                }
            }
        }
    }
}
