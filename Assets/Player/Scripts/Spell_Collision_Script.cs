using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TODO: Add spell collision effects on health bars
public class Spell_Collision_Script : MonoBehaviour
{
    public float spellPower;
    public GameObject spell;
    public static bool spellCast;
    // Use this for initialization
    private void Start()
    {
        spellCast = true;
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Targetable"))
        {
            spellCast = false;
            Destroy(spell);
            Player_Attributes playerStats = (Player_Attributes)collision.gameObject.GetComponent("Player_Attributes");
            playerStats.healthPool -= spellPower;
            if (playerStats.healthPool <= 0)
            {
                print(collision.gameObject + " health: " + playerStats.healthPool);
                Destroy(collision.gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("Environment"))
        {
            spellCast = false;
            Destroy(spell);
        }
    }
}
/* 6-27-18 
 * -Added the Environment tag and a condition that allowed for spell to disipate if the spell comes into contact
   with an object tagged 'Environment'. In order to make the collision work with the environment, I had to give the objects tagged 
   'Environment' a RigidBody and ensure that the RigidBody was non-kinematic. In order to keep the environment stationary in this context,
   I froze the x, y, z position and rotation.
   -In order to deduct health points from the target when the projectile made contact, I had to use the GetComponent function to
   get the component 'Player_Attributes' and store its data into a 'Player_Attributes' object (?). From there I was able to access the member
   variables of the class as though it was a reference to an object.
   -Added a modifiable spell-power value to the editor to facilitate ease of development*/
//---------------------------------------------------------------------------------------------------------------------------------------------