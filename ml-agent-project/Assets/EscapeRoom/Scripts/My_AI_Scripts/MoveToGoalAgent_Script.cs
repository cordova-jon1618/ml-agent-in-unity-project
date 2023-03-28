using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents.Actuators;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class MoveToGoalAgent_Script : Agent
{



    //private Rigidbody rb;
    //private float speed = 5f;
    //private int direction = 1;
    //private Camera cam;



    [SerializeField] private Transform targetTransform;
    [SerializeField] private Material winMaterial;
    [SerializeField] private Material loseMaterial;
    [SerializeField] private MeshRenderer floorMeshRender;


    public override void OnEpisodeBegin()
    {
        transform.localPosition = Vector3.zero;
        transform.rotation = Quaternion.identity;
    }


    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(targetTransform.localPosition);
    }
    public override void OnActionReceived(ActionBuffers actions)
    {
        // Debug.Log(actions.DiscreteActions[0]);
        Debug.Log(actions.ContinuousActions[0]);
        float moveX = actions.ContinuousActions[0] * 5;
        float moveZ = actions.ContinuousActions[1] * 5;

        float moveSpeed = 5f;
        transform.localPosition += new Vector3(moveX, 0, moveZ) * Time.deltaTime * moveSpeed;
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {


        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;

        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");

        //Vector3 movement = new Vector3(continuousActions[0], 0f, continuousActions[1]);
        //rb.velocity = 2f * direction * speed * movement;

        /*
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        rb.velocity = 2f * direction * speed * movement;

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
        */

    }//end Heuristics

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Goal>(out Goal goal))
        {
            Debug.Log("Reward Win!");
            SetReward(+1f);
            floorMeshRender.material = winMaterial;
            EndEpisode();
        }
        if (other.TryGetComponent<Wall>(out Wall wall))
        {
            Debug.Log("Reward Loss!");
            SetReward(-1f);
            floorMeshRender.material = loseMaterial;
            EndEpisode();
        }

    }


}
