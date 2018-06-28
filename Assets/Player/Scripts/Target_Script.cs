using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Script : MonoBehaviour
{
    public GameObject playerObject;
    public Transform player;
    public Transform arena_1;
    public Transform arena_2;
    public Transform arena_3;

    private void Start()
    {
        Camera_Position_Script.target = player;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
           //playerObject.transform.LookAt(arena_1);
           Camera_Position_Script.target = arena_1;
        }
        if(Input.GetKey(KeyCode.Alpha2))
        {
            //playerObject.transform.LookAt(arena_2);
            Camera_Position_Script.target = arena_2;
        }
        if(Input.GetKey(KeyCode.Alpha3))
        {
            //playerObject.transform.LookAt(arena_3);
            Camera_Position_Script.target = arena_3;
        }
        if(Input.GetKey(KeyCode.Tab))
        {
            Camera_Position_Script.target = player;
        }
        playerObject.transform.LookAt(Camera_Position_Script.target);
    }
}
/* 6-27-2018 Tried to force the player model to face the target when targeting a targetable object. Ran into a problem
 where having a LookAt function in each if statement would only face the player to the target for 1 frame. Solution was to
 add a line after the if statements but still in the update loop to force the player to face whatever 
 'Camera_Position_Script.target' was equal to.*/