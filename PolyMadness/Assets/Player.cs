using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Normal Movements Variables
    private float walkSpeed;
    private float curSpeed;
    private float maxSpeed;
    private Rigidbody rb;

    //private CharacterStat plStat;

    void Start()
    {
        //plStat = GetComponent<CharacterStat>();
        rb = GetComponent<Rigidbody>();
        walkSpeed = (float)(100 + (10 / 5));
        //sprintSpeed = walkSpeed + (walkSpeed / 2);

        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.z = 0;
        transform.rotation = Quaternion.Euler(rotationVector);

    }

    private void Update()
    {
        if (Input.GetKey("up"))
        {
            rb.AddForce(transform.forward * 40f, ForceMode.Acceleration);
        }
        if (Input.GetKey("left"))
        {
            //rb.AddForce(transform.forward * 100f, ForceMode.Acceleration);
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.y -= 2;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
        if (Input.GetKey("right"))
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.y += 2;
            transform.rotation = Quaternion.Euler(rotationVector);
            //rb.AddForce(transform.forward * 100f, ForceMode.Acceleration);

        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(transform.forward * -20f, ForceMode.Acceleration);
        }

        
    }

    void FixedUpdate()
    {
        curSpeed = walkSpeed;
        maxSpeed = curSpeed;

        // Move senteces
       // rb.velocity = new Vector3(Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f),0,Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f));
    }
}