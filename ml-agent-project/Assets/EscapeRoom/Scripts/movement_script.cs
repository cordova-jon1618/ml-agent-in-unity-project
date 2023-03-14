using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class movement_script : MonoBehaviour
{

    private Camera cam;
    private bool isClicked = false;

    private Rigidbody rb;
    public float speed = 5f;
    // The direction determines where the agent is facing
    private int direction = 1;

    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }


    public void OnObjectClicked(GameObject clickedObject)
    {
        //Debug.Log(clickedObject.name + " was clicked!");
        isClicked = true;
    }

    public void OnObjectNotClicked(GameObject notclickedObject)
    {
        //Debug.Log(notclickedObject.name + " was clicked!");
        isClicked = false;
    }


    void Update()
    {

        if (isClicked)
        {

            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");


            //Directional controls - moving the agent using the rigidbody's velocity to prevent walking through walls
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            rb.velocity = 2f * direction * speed * movement;

            // Orientation for directional based on Camera viewpoint
            if (horizontalInput != 0 || verticalInput != 0)
            {
                Vector3 forward = cam.transform.forward;
                forward.y = 0;
                Vector3 right = cam.transform.right;
                right.y = 0;
                forward.Normalize();
                right.Normalize();

                Vector3 direction = (horizontalInput * right + verticalInput * forward).normalized;
                if (direction.magnitude > 0.1f)
                {
                    transform.rotation = Quaternion.LookRotation(-direction);
                }
            }


        }//end isClicked if statement

    }//end update

}//end class