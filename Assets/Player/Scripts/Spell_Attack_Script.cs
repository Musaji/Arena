using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell_Attack_Script : MonoBehaviour
{
    public Transform player;
    // Use this for initialization
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;
    private SphereCollider sphereCollider;
    private BoxCollider boxCollider;

    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.F))
        {
            print("Generate Spell");
            GameObject spell = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            spell.transform.position = player.position;
            Collider spellCollider = spell.GetComponent<Collider>();
            //TODO: Implement collider functionality for while loop exit condition
            while (Camera_Position_Script.target != player && /*spell has not collided with the target yet */)
            {
                spell.transform.LookAt(Camera_Position_Script.target);
                spell.transform.Translate(Vector3.forward, Space.Self);
            }
        }
	}
}
