using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Script : MonoBehaviour
{
    public GameObject player;
    public float forwardVelocity = .2f;
	// Use this for initialization
	void Start ()
    {
        
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            print("Forward");
            transform.Translate(Vector3.forward * forwardVelocity, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            print("Backward");
            transform.Translate(-Vector3.forward * forwardVelocity, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("Left");
            transform.Translate(Vector3.left * forwardVelocity, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            print("Right");
            transform.Translate(Vector3.right * forwardVelocity, Space.Self);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            print("Rotate Left");
            transform.Rotate(-Vector3.up, Space.Self);
        }
        if(Input.GetKey(KeyCode.E))
        {
            print("Rotate right");
            transform.Rotate(Vector3.up, Space.Self);
        }
    }
}
