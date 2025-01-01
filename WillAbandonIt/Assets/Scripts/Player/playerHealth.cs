using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int health;
    private int oldhealth;
    // Start is called before the first frame update
    void Start()
    {
        oldhealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("Nie zyjesz");
        }
        else if (oldhealth > health)
        {
            Debug.Log("Straciles zycie");
        }
        else if (oldhealth < health)
        {
            Debug.Log("Zyskales zycie");
        }
    }
}
