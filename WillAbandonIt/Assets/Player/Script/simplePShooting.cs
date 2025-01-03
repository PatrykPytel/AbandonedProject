using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplePShooting : MonoBehaviour
{
    private float cooldown = 0.1f;
    private float restartcooldown;
    public GameObject bullet;
    public Transform firePoint;
    public float bulletSpeed = 50;
    private Vector2 bulletDirection;
    //private Animator animator;

    private void Start()
    {
        restartcooldown = cooldown;
        cooldown = 0;
        //animator = GetComponent<Animator>();
    }


    private void Update()
    {
  
     //   Vector2 dir = Vector2.zero;
        if (cooldown <= 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GameObject bulletClone = Instantiate(bullet);
                bulletClone.transform.position = firePoint.position;
                bulletClone.transform.eulerAngles = new Vector3(bulletClone.transform.eulerAngles.x, bulletClone.transform.eulerAngles.y, bulletClone.transform.eulerAngles.z + 90);
                bulletDirection = new Vector2(-1, 0);
             //       movementDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
                bulletClone.GetComponent<Rigidbody2D>().velocity = bulletDirection * bulletSpeed;
                cooldown = restartcooldown;

                //  dir.x = -1;
                //      animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                GameObject bulletClone = Instantiate(bullet);
                bulletClone.transform.position = firePoint.position;
                bulletClone.transform.eulerAngles = new Vector3(bulletClone.transform.eulerAngles.x, bulletClone.transform.eulerAngles.y, bulletClone.transform.eulerAngles.z - 90)  ;
                bulletDirection = new Vector2(1, 0);
                bulletClone.GetComponent<Rigidbody2D>().velocity = bulletDirection * bulletSpeed;
                cooldown = restartcooldown;
                //   dir.x = 1;
                //    animator.SetInteger("Direction", 2);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                GameObject bulletClone = Instantiate(bullet);
                bulletClone.transform.position = firePoint.position;
                // bulletClone.transform.eulerAngles = new Vector3(0, 0, 0);
                bulletDirection = new Vector2(0, 1);
                bulletClone.GetComponent<Rigidbody2D>().velocity = bulletDirection* bulletSpeed;
                cooldown = restartcooldown;
                //dir.y = 1;
                //  animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                GameObject bulletClone = Instantiate(bullet);
                bulletClone.transform.position = firePoint.position;
                bulletClone.transform.eulerAngles = new Vector3(bulletClone.transform.eulerAngles.x, bulletClone.transform.eulerAngles.y, bulletClone.transform.eulerAngles.z + 180);
                bulletDirection = new Vector2(0,-1);
                bulletClone.GetComponent<Rigidbody2D>().velocity =bulletDirection * bulletSpeed;
                cooldown = restartcooldown;
                // dir.y = -1;
                //animator.SetInteger("Direction", 0);
            }
        }
        else
        {
            cooldown -= Time.deltaTime;
        }

        //dir.Normalize();
        //animator.SetBool("IsMoving", dir.magnitude > 0);

       // GetComponent<Rigidbody2D>().velocity = speed * dir;
    }

}

