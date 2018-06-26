using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Position_Script : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    public Vector3 offset;

	// Update is called once per frame
	void Update ()
    {
        //TODO: Transform Position to be that of target.
        //offset value is global, not local.
        print(target.position);
        transform.LookAt(target);
        transform.position = target.TransformPoint(offset);
	}
}
