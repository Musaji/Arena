using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Position_Script : MonoBehaviour
{
    public static Transform target;
    public Transform player;
    public Vector3 offset;

	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(target);
        transform.position = player.TransformPoint(offset);
	}
}
