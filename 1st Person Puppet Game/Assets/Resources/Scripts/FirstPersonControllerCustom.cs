using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonControllerCustom : MonoBehaviour
{
    private Rigidbody rb;

    public float force = 1.0f;

    public float rotationSpeed = 100f;

    public float sensX = 1f;

    public float sensY = 1f;

    public float xRotation;

    public float yRotation;

    public Transform orientation;

    public float mouseX;

    public float mouseY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        //rotate camera and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        
        //controller using input to get directions
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movementDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        movementDirection.Normalize();
        
        rb.AddForce(movementDirection * force * 2f, ForceMode.Force);
    }
}
