using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class movement_script : MonoBehaviour
{

    public int direction = 15;
    public float rotationSpeed = 250f;
    private Camera cam;
    private bool isClicked = false;

    void Start()
    {
        cam = Camera.main;
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

            //Directional
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(transform.right * -direction * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(transform.right * direction * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(transform.forward * direction * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(transform.forward * -direction * Time.deltaTime);
            }


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