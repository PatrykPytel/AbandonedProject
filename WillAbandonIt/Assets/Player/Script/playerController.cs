using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [Range(0, .3f)][SerializeField] private float movementSmoothing = .05f;

    [SerializeField] private float movementSpeed = 10f;
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    private Vector3 velocity = Vector3.zero;
    public float cooldown = 1f;
    private float oldcooldown;
    private float dashtime = 0.5f;
    private float mnoznik = 3f;

    // Start is called before the first frame update
    private void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        oldcooldown = cooldown;
        cooldown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2( Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) ;
        if (cooldown <= 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                cooldown = oldcooldown;
                //   animator.SetBool("Isdashing", true);
                // animator.SetBool("IsJumping", false);
                movementSpeed = movementSpeed * mnoznik;
                Invoke("stopdash", dashtime);

            }
        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = Vector3.SmoothDamp(rb.velocity, movementDirection * movementSpeed, ref velocity, movementSmoothing);

    }//m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
    void stopdash()
    {
        movementSpeed = movementSpeed/ mnoznik;
     //   animator.SetBool("Isdashing", false);
        //       animator.SetBool("IsJumping",true);

    }
}
