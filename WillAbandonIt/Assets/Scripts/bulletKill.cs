using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletKill : MonoBehaviour
{
    public float bulletCooldown = 5f;
    [SerializeField] private GameObject bullet; 
    [SerializeField] private HealthDown healthDown;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (healthDown.killsplayer && collision.tag == "Player")
        {
            Destroy(bullet);
        }else if ( healthDown.killsenemy && collision.tag == "Enemy")
        {
            Destroy(bullet);
        }else if (collision.tag != "Enemy" &&  collision.tag != "Player")
        {
         
            Destroy(bullet);
        }
    }
}
