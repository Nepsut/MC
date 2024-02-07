using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 700f;

    public Transform playerBody; //reference to camera

    float xRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //locks mouse to the middle of sc
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;


        xRotation -= mouseY;  //-= cos othervise it flips around
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  //Limits rotation to  (clamping)

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);  //Quaternion is responsible for rotation in unity...
        playerBody.Rotate(Vector3.up * mouseX);


    }
}
