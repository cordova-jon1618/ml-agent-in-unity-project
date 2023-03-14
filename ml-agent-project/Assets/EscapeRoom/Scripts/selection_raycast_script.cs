using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selection_raycast_script : MonoBehaviour
{

    public GameObject cube_targetObject; 
    public GameObject sphere_targetObject; 
    public GameObject capsule_targetObject; 


    void Start()
    {

    }

    // The object that will receive information if a click is detected
    void Update()
    {
        //left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if (hit)
            {
                //Debug.Log(hitInfo.transform.name);

                if (hitInfo.transform.name.Equals("Cube"))
                {
                    Debug.Log(hitInfo.transform.name + " is selected!");
                    cube_targetObject.SendMessage("OnObjectClicked", gameObject, SendMessageOptions.RequireReceiver);
                    sphere_targetObject.SendMessage("OnObjectNotClicked", gameObject, SendMessageOptions.RequireReceiver);
                    capsule_targetObject.SendMessage("OnObjectNotClicked", gameObject, SendMessageOptions.RequireReceiver);
                }
                else if (hitInfo.transform.name.Equals("Sphere"))
                {
                    Debug.Log(hitInfo.transform.name + " is selected!");
                    sphere_targetObject.SendMessage("OnObjectClicked", gameObject, SendMessageOptions.RequireReceiver);
                    cube_targetObject.SendMessage("OnObjectNotClicked", gameObject, SendMessageOptions.RequireReceiver);
                    capsule_targetObject.SendMessage("OnObjectNotClicked", gameObject, SendMessageOptions.RequireReceiver);
                }
                else if (hitInfo.transform.name.Equals("Capsule"))
                {
                    Debug.Log(hitInfo.transform.name + " is selected!");
                    capsule_targetObject.SendMessage("OnObjectClicked", gameObject, SendMessageOptions.RequireReceiver);
                    sphere_targetObject.SendMessage("OnObjectNotClicked", gameObject, SendMessageOptions.RequireReceiver);
                    cube_targetObject.SendMessage("OnObjectNotClicked", gameObject, SendMessageOptions.RequireReceiver);
                }
            }
            else
            {
                //do nothing!
            }
        }

    }//end Update

}//end selection_raycast_script
