using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObamaSpherescript : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    public AudioSource biem;

    public Transform playertarget;
    private GameObject target;

    private float nextFire;
    public float fireRate;
    public Transform kogelspawn;
    public GameObject shot;

    void start()
    {

        rb = GetComponent<Rigidbody>();
        biem = GetComponent<AudioSource>();
        nextFire = Time.time + fireRate;
    }
    void Update()
    {
        target = GameObject.FindWithTag("playertag");
        transform.LookAt(target.transform);
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, kogelspawn.position, kogelspawn.rotation);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("kogels"))
        {
            biem.Play(0);
            obamaSpawnerScript.alienLeven -= 1;
            Destroy(gameObject);
        }
    }
}
