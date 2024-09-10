using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody rb;
    public float thrust = 20f;
    public float maxSpeed = 10f;
    public float rotateSpeed = 20f;
    public float rotationSpeed = 100f;
    public GameObject RPW, RDW, FPW, FDW;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //rotates the player up
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        }

        //rotates the player down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        //move player to the Right
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * thrust * Time.deltaTime, ForceMode.Acceleration);
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
            RPW.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            RDW.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            FPW.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
            FDW.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }

        ////move player to the Left
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * thrust * Time.deltaTime, ForceMode.Acceleration);
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
            RPW.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            RDW.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            FPW.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            FDW.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        
    }
}
