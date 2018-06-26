using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Script : MonoBehaviour
{
    Transform noTarget;
    public Transform player;
    public Transform arena_1;
    public Transform arena_2;
    public Transform arena_3;
	

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        { 
            Camera_Position_Script.target = arena_1;
        }
        if(Input.GetKey(KeyCode.Alpha2))
        {
            Camera_Position_Script.target = arena_2;
        }
        if(Input.GetKey(KeyCode.Alpha3))
        {
            Camera_Position_Script.target = arena_3;
        }
        if(Input.GetKey(KeyCode.Tab))
        {
            Camera_Position_Script.target = player;
        }
    }
}
