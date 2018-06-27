using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell_Collision_Script : MonoBehaviour
{
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
        if(collision.gameObject.CompareTag("Targetable"))
        {
            spellCast = false;
            Destroy(spell);
        }
    }
}
