using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class levmanage : MonoBehaviour
{
    public static levmanage instance;

    public Transform respawnPoint;
    public GameObject playerPrefab;



    private void Awake()
    {
        instance = this;
    }



    public void Respawn()
    {
        GameObject Player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);

    }

    void Start()
    {


    }


    void Update()
    {


    }
}
