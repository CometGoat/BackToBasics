using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {

    float mouseX;
    float mouseY;
    public float mouseSensitivity;
    float rotAmount_X;
    float rotAmount_Y;
    Vector3 targetRot_Cam;
    Vector3 targetRot_Body;

    public Transform playerBody;

    // Use this for initialization
    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        rotAmount_X = mouseX * mouseSensitivity;
        rotAmount_Y = mouseY * mouseSensitivity;

        targetRot_Cam = transform.rotation.eulerAngles;
        targetRot_Body = playerBody.rotation.eulerAngles;

        targetRot_Cam.x -= rotAmount_Y;
        targetRot_Body.y += rotAmount_X;

        transform.rotation = Quaternion.Euler(targetRot_Cam);
        playerBody.rotation = Quaternion.Euler(targetRot_Body);
	}
}
