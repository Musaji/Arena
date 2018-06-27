using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell_Attack_Script : MonoBehaviour
{
    public GameObject spell;
    public Transform player;
    public Transform spellOffset; //un-implemented offset to set where spell materializes in-game
    // Use this for initialization
    public float spellSpeed;
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;
    private SphereCollider sphereCollider;
    private BoxCollider boxCollider;
    private Collider spellCollider;
    private Rigidbody spellRigidBody;
    private GameObject spellClone;

    // Update is called once per frame
    void Update()
    {
        print(player.transform);
        if (Input.GetKeyDown(KeyCode.F) && Spell_Collision_Script.spellCast == false)
        {
            print("Generate Spell");
            spellClone = Instantiate(spell);
            spellClone.transform.position = player.transform.position;
        }

        if (spellClone)/*spell has not collided with the target yet  and the spell still exists*/
        {
            spellClone.transform.LookAt(Camera_Position_Script.target);
            spellClone.transform.Translate(Vector3.forward, Space.Self);
            //spellRigidBody.AddForce(spell.transform.forward * spellSpeed);
            //OnTriggerEnter(spellCollider);
        }
        //TODO: Implement collider functionality for while loop exit condition and implement collider
    }
}
/* 6-26-2018: initially attempted to use the create primitive function to create a sphere to represent the spell. Unfortunately,
 * I ran into a problem where I could not get the "spell" to be destroyed upon collision with the right 
 * target. I could either have it be destroyed immediately (since it collides with the player) or not 
 * be destroyed at all. In order to make use of the OnCollisionEnter() function and also to set a framework
 * for different types of spells, I have decided instead to create spell prefabs with their own scripts
 * attached that will allow for specialized functionality and modularity of spell assets. */