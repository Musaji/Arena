using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attributes : MonoBehaviour
{
    public float healthPool;
    public float manaPool;
    
    void Start()
    {
        healthPool = 100;
        manaPool = 100;
    }
    private void Update()
    {
        print(gameObject + "health: " + healthPool);
    }
}
