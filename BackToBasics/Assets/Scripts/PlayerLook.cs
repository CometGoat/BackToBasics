using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {

    float mouseX;
    float mouseY;
    public float mouseSensitivity;
    float rotAmount_X;
    float rotAmount_Y;
    Vector3 targetRot;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        rotAmount_X = mouseX * mouseSensitivity;
        rotAmount_Y = mouseY * mouseSensitivity;

        targetRot = transform.rotation.eulerAngles;

        targetRot.x += rotAmount_Y;
        targetRot.y += rotAmount_X;

        transform.rotation = Quaternion.Euler(targetRot);
	}
}
