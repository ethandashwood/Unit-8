using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }




    void Update()
    {
        float xSpeed = 0.0f;
        float ySpeed = -0.0f;


        if (Input.GetKey("d"))
        {

            xSpeed = 8.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0f, 0);
        }

        if (Input.GetKey("a"))
        {

            xSpeed = -8.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180f, 0);

        }
    }
}
