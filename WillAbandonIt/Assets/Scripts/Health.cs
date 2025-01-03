using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    private float oldhealth;
    // Start is called before the first frame update
    void Start()
    {
        oldhealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0f)
        {
            Debug.Log("Nie zyjesz");
            oldhealth = health;
        }
        else if (oldhealth > health)
        {
            Debug.Log("Straciles zycie");
            oldhealth = health;
        }
        else if (oldhealth < health)
        {
            Debug.Log("Zyskales zycie");
            oldhealth = health;
        }
    }
}
