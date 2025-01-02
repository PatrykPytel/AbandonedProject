using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletKill : MonoBehaviour
{
    public float bulletCooldown = 1f;
    public GameObject bullet; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletCooldown < 0f)
        {
             Destroy(bullet);
        }else
        {
            bulletCooldown -= Time.deltaTime; 
        }
    }
}
