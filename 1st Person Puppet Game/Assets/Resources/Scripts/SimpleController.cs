using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 5.0f;
    private Vector3 movementDirection;
    public bool isPlayerWalking;
    
    //camera
    public Transform camera;
    public float sensX = 1f;
    public float sensY = 1f;
    public float xRotation;
    public float yRotation;
    public Transform orientation;
    public float mouseX;
    public float mouseY;
    public GameObject camManager;
    public float playerHeight;

    private void Awake()
    {
        isPlayerWalking = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isPlayerWalking = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        FirstPerson();
        
        camera.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        camera.position = orientation.position;
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        transform.rotation = orientation.rotation;
        
        //controller using input to get directions
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        if (horizontalInput > 0 || horizontalInput < 0 || verticalInput >0 || verticalInput < 0)
        {
            isPlayerWalking = true;
        }
        else
        {
            isPlayerWalking = false;
        }

        movementDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(movementDirection.normalized * force * 10f, ForceMode.Force);
    }

    public void FirstPerson()
    {
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
}
