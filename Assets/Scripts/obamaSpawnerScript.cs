using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class obamaSpawnerScript : MonoBehaviour
{
    private int randomNummer;
    private int randomNummerx;
    private int randomNummery;
    private int randomNummerz;

    public static int alienLeven = 1;

    public GameObject bal;
    public Transform balspawn1;
    public Transform balspawn2;
    public Transform balspawn3;
    public Transform balspawn4;

    private Vector3 spawnVec;


    void Start()
    {
        Debug.Log("hello there");

        randomNummerx = Random.Range(-30, 50);
        randomNummery = Random.Range(5, 15);
        randomNummerz = Random.Range(25, 45);
        spawnVec = new Vector3(randomNummerx, randomNummery, randomNummerz);
        Debug.Log(randomNummer);
        Instantiate(bal, spawnVec, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        if (alienLeven < 1)
        {
            randomNummerx = Random.Range(-30, 50);
            randomNummery = Random.Range(5, 15);
            randomNummerz = Random.Range(25, 45);
            spawnVec = new Vector3(randomNummerx, randomNummery, randomNummerz);
            Debug.Log(randomNummer);
            Instantiate(bal, spawnVec, Quaternion.identity);
            alienLeven += 1;
        }
    }
}
