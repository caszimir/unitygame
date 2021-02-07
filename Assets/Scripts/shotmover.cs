using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotmover : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    public AudioSource biem;

    void start()
    {
        rb = GetComponent<Rigidbody>();
        biem = GetComponent<AudioSource>();
    }
    void Update()
    {
        rb.velocity = transform.forward * speed;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("playertag"))
        {
            biem.Play(0);
        }
    }
}
