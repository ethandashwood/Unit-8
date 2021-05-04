using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }




    void Update()
    {
        float xSpeed = 0.0f;


        if (Input.GetKey("d"))
        {

            xSpeed = 8.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0f, 0);
            anim.SetBool("iswalking", true);
            anim.SetBool("isidle", false);
        }

        if (Input.GetKey("a"))
        {

            xSpeed = -8.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            anim.SetBool("iswalking", true);
            anim.SetBool("isidle", false);

            
        }

        if (Input.GetKey("w"))
        {
            float jvol = 5.0f;
            rb.velocity = Vector2.up * jvol;
            anim.SetBool("isjump", true);
            anim.SetBool("iswalking", false);
            anim.SetBool("isidle", false);
        }



        if (xSpeed == 0.0f)
        {
            anim.SetBool("isidle", true);
            anim.SetBool("iswalking", false);
        }

    }
}
