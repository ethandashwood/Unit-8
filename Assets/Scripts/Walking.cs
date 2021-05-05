using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    Rigidbody2D rb;
    public Animator anim;
    private BoxCollider2D boxCollider2d;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        BoxCollider2d = GetComponent<Rigidbody2D>();
    }




    void Update()
    {
        float xSpeed = 0.0f;


        float jvol = 0.0f;

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

        if (isground() && Input.GetKey("w"))
        {
            jvol = 7.0f;
            rb.velocity = Vector2.up * jvol;
            anim.SetBool("isjump", true);
            anim.SetBool("iswalking", false);
            anim.SetBool("isidle", false);
        }



        if (xSpeed == 0.0f && jvol == 0.0)
        {
            anim.SetBool("isidle", true);
            anim.SetBool("iswalking", false);
        }

        if (jvol == 0.0)
        {
            anim.SetBool("isjump", false);

        }

        if (jvol > 0.1)
        {
            anim.SetBool("iswalking", false);
            anim.SetBool("isjump", true);
            anim.SetBool("isidle", false);

        }

        private bool isground()
        {

        RaycastHit2d raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 0.1f);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;

        }
    }

}
