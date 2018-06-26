using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attributes : MonoBehaviour
{
    public float healthPool;
    public float manaPool;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        print("Health is: " + healthPool);

        print("Mana is: " + manaPool);
	}
}
