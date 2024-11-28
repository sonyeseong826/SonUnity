using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rigidbody = new Rigidbody();
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            rigidbody.velocity = new Vector3(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.velocity = new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.velocity = new Vector3(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.velocity = new Vector3(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.velocity = new Vector3(0, 5, 0);
        }
    }
}
