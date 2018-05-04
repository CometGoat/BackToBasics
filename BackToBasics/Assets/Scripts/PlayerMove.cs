using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    CharacterController charControl;
    public float walkSpeed;
    public float jumpStrength = 1.0f;
    public Rigidbody boob; 

	// Use this for initialization
	void Start ()
    {
        charControl = GetComponent<CharacterController>();
        boob = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //boob.velocity = new Vector3(0, 10 * jumpStrength, 0);
            boob.AddForce(new Vector3(100, 100, 100), ForceMode.Impulse);
            print("splooble booble");
        }
    }

	
	// Update is called once per frame
	void Update ()
    {
         MovePlayer();

        //if (Input.GetKeyDown("space"))
        //{
        //    boob.velocity = new Vector3(0, 10 * jumpStrength, 0);
        //    print("splooble booble");
        //}

    }

    void MovePlayer()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 moveDirSide = transform.right * horiz * walkSpeed;
        Vector3 moveDirForward = transform.forward * vert * walkSpeed;

        charControl.SimpleMove(moveDirSide);
        charControl.SimpleMove(moveDirForward);
    }
}
