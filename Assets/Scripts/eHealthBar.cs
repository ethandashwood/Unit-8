using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eHealthBar : MonoBehaviour
{

    public float enemyhealth;
    public Transform winscreen;

    void Start()
    {



    }


    void Update()
    {


 

        if (Walking.enhealth <= 90.0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.045f, 0.05566879f);

        }

        if (Walking.enhealth <= 80.0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.04f, 0.05566879f);

        }

        if (Walking.enhealth <= 70.0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.035f, 0.05566879f);

        }

        if (Walking.enhealth <= 60.0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.03f, 0.05566879f);

        }

        if (Walking.enhealth <= 50.0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.025f, 0.05566879f);

        }

        if (Walking.enhealth <= 40.0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.02f, 0.05566879f);

        }

        if (Walking.enhealth <= 30.0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.015f, 0.05566879f);

        }

        if (Walking.enhealth <= 20.0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.01f, 0.05566879f);

        }

        if (Walking.enhealth <= 10.0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.005f, 0.05566879f);

        }

        if (Walking.enhealth <= 0f)
        {
            Transform eBar = transform.Find("Red");
            eBar.localScale = new Vector2(.0001f, 0.05566879f);
            Destroy(GameObject.FindWithTag("Enemy"));

            Instantiate(winscreen);

        }
    }
}
