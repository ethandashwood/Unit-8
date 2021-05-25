using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pHealthBar : MonoBehaviour
{

    public static float playerHealth;


    void Start()
    {
        Transform bar = transform.Find("GB");
        bar.localScale = new Vector2(.05f, 0.05566879f);

        playerHealth = 100.0f;
    }
    


    void Update()
    {
        if (playerHealth == 90.0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.045f, 0.05566879f);

        }

        if (playerHealth == 80.0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.04f, 0.05566879f);

        }

        if (playerHealth == 70.0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.035f, 0.05566879f);

        }

        if (playerHealth == 60.0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.03f, 0.05566879f);

        }        

        if (playerHealth == 50.0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.025f, 0.05566879f);

        }

        if (playerHealth == 40.0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.02f, 0.05566879f);

        }

        if (playerHealth == 30.0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.015f, 0.05566879f);

        }

        if (playerHealth == 20.0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.01f, 0.05566879f);

        }

        if (playerHealth == 10.0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.005f, 0.05566879f);


        }

        if (playerHealth == 0f)
        {   
            Transform bar = transform.Find("GB");
            bar.localScale = new Vector2(.0001f, 0.05566879f);

            Destroy(GameObject.FindWithTag("Player"));

        }
        

    }
}
