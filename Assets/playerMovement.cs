using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public Rigidbody rb;
    public AudioManager miAM;
    bool hasJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hasJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space)&& hasJump)
        {
            
            hasJump = false;
            
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            miAM.PlaySalto();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "piso")
        {
            hasJump = true;
            jumpForce = 3;
        }
        if (col.gameObject.name == "PisoRampa")
        {
            jumpForce = 5;
        }
        if (col.gameObject.name == "PisoVentilador")
        {
            jumpForce = 5;
        }
    }
}
