using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Script : MonoBehaviour
{
    public GameObject player;
    public float forwardVelocity = .2f;

    // Update is called once per frame
    //TODO: Make movement framerate independent
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * forwardVelocity, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * forwardVelocity, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * forwardVelocity, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * forwardVelocity, Space.Self);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-Vector3.up, Space.Self);
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, Space.Self);
        }
    }
}
