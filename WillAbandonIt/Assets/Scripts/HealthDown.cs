using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDown : MonoBehaviour
{
    public bool killsplayer = false;
    public bool killsenemy = true;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Health>() != null)
        {
            if (killsplayer && collision.tag == "Player")
            {   
                collision.GetComponent<Health>().health -= damage;  
            }
            else if (killsenemy && collision.tag == "Enemy")
            {
                collision.GetComponent<Health>().health -= damage;
            }
        }
    }
}
