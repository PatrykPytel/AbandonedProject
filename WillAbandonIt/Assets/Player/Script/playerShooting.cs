using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    private float cooldown = 0.3f;
    private float restartcooldown;
    public float damage = 0.5f;
    public GameObject bullet;
    public Transform firePoint;
    public float bulletSpeed = 50;
    [SerializeField] private playerController Finalmovement;

    Vector2 lookDirection;
    float lookAngle;
    void Start()
    {
        restartcooldown = cooldown;
        cooldown = 0;
    }
    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0, 0, lookAngle);

        if (Input.GetKeyDown(KeyCode.Mouse0) && cooldown <= 0)
        {
            GameObject bulletClone = Instantiate(bullet);
            bulletClone.transform.position = firePoint.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().velocity = firePoint.right * bulletSpeed;
            cooldown = restartcooldown;
            
            
        }
        else
        {
            cooldown -= Time.deltaTime;
        }

    }

}