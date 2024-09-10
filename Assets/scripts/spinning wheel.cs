using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinningwheel : MonoBehaviour
{
    public float rotateSpeed = 100f;


    // Update is called once per frame
    void Update()
    {
        //spins the wheel on z axis
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
}
