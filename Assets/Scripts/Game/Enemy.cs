using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    public float velocity;
    public float links;

    private Vector3 rotation;

    void Start()
    {
        velocity = transform.position.x + velocity;
        links = transform.position.x - links;
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < links) {
            transform.eulerAngles = rotation - new Vector3(0,180,0);
        }

        if (transform.position.x > velocity) {
                transform.eulerAngles = rotation ;
        }
    }
}