using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Walking : MonoBehaviour
{
    Rigidbody2D rb;
    private Animator anim;
    private BoxCollider2D col;
    public static bool pblock;
    private bool inRange;
    public static float enHealth;
    private int attackCount;


    [SerializeField] private LayerMask platLayM;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        col = transform.GetComponent<BoxCollider2D>();
        pblock = false;
        enHealth = 100.0f;
        attackCount = 0;

    }



    void Update()
    {

        float xSpeed = 0.0f;
        

        float jvol = 0.0f;

        if (Input.GetKey("d"))
        {

            xSpeed = 13.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0f, 0);
            anim.SetBool("iswalking", true);
            anim.SetBool("isidle", false);
            anim.SetBool("ispunch", false);
    }

        if (Input.GetKey("a"))
        {

            xSpeed = -13.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            anim.SetBool("iswalking", true);
            anim.SetBool("isidle", false);
            anim.SetBool("ispunch", false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            pblock = true;

        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            pblock = false;

        }

        if (isGround() && Input.GetKey("w"))
        {
            jvol = 15.0f;
            rb.velocity = Vector2.up * jvol;
            anim.SetBool("isjump", true);
            anim.SetBool("iswalking", false);
            anim.SetBool("isidle", false);
            anim.SetBool("ispunch", false);


        }

        if (Input.GetKeyDown(KeyCode.E) && inRange ==true && attackCount = 2)
        {

            enHealth -= 5.0f;

            anim.SetBool("ispunch", true);

            attackCount -= 1;

            if (anim.GetCurrentAnimatorStateInfo(0).IsName("pazpunch") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.5f)
            {
                anim.SetBool("ispunch", false);
                Debug.Log("punch anim finished");
            }

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
            anim.SetBool("ispunch", false);


        }


    }

    private bool isGround()
    {
        float exHeightT = .1f;
        RaycastHit2D raycastHit = Physics2D.Raycast(col.bounds.center, Vector2.down, col.bounds.extents.y + exHeightT, platLayM);
        Color rayColour;

        if (raycastHit.collider != null)
        {
            rayColour = Color.green;
        }
        else
        {
            rayColour = Color.red;
        }

        Debug.DrawRay(col.bounds.center, Vector2.down * (col.bounds.extents.y + exHeightT));
        return raycastHit.collider != null;
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        
        inRange = true;

    }


}
