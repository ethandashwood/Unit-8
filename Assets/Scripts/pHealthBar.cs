using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pHealthBar : MonoBehaviour
{

    void Start()
    {
        Transform bar = transform.Find("GB");
        bar.localScale = new Vector2(.025f, 0.05566879f);
    }


    void Update()
    {

    }
}
