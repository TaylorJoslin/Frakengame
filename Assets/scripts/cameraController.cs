using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public float speed = 10f;
    public float stopPoint = 10f;
    private Vector3 velocity = Vector3.zero;
    bool movingRight = true;


    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        

        if (transform.position.x >= stopPoint)
        {
            movingRight = false;
        }
        


    }
}
