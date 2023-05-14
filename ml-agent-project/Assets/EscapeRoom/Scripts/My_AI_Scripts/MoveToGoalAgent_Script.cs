using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents.Actuators;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class MoveToGoalAgent_Script : Agent
{

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

        Camera cam = Camera.main;

        //Debug.Log(actions.ContinuousActions[0]);
        float moveX = actions.ContinuousActions[0] * 5;
        float moveZ = actions.ContinuousActions[1] * 5;

        float moveSpeed = 3f;
        transform.localPosition += new Vector3(moveX, 0, moveZ) * Time.deltaTime * moveSpeed;

        // Orientation for directional based on Camera viewpoint
        if (actions.ContinuousActions[0] != 0 || actions.ContinuousActions[1] != 0)
        {
            Vector3 forward = cam.transform.forward;
            forward.y = 0;
            Vector3 right = cam.transform.right;
            right.y = 0;
            forward.Normalize();
            right.Normalize();

            Vector3 direction = (actions.ContinuousActions[0] * right + actions.ContinuousActions[1] * forward).normalized;
            if (direction.magnitude > 0.1f)
            {
                transform.rotation = Quaternion.LookRotation(-direction);
            }
        }

        // Calculate distance to the goal
        float distance = Vector3.Distance(transform.position, targetTransform.position);
        // Add reward for getting closer to the goal
        float increment_rewards = 0.15f * (1f / distance);
        Debug.Log(increment_rewards);
        AddReward(increment_rewards);

    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        Camera cam = Camera.main;

        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;

        continuousActions[0] = Input.GetAxisRaw("Horizontal");
        continuousActions[1] = Input.GetAxisRaw("Vertical");


        // Orientation for directional based on Camera viewpoint
        if (continuousActions[0] != 0 || continuousActions[1] != 0)
        {
            Vector3 forward = cam.transform.forward;
            forward.y = 0;
            Vector3 right = cam.transform.right;
            right.y = 0;
            forward.Normalize();
            right.Normalize();

            Vector3 direction = (continuousActions[0] * right + continuousActions[1] * forward).normalized;
            if (direction.magnitude > 0.1f)
            {
                transform.rotation = Quaternion.LookRotation(-direction);
            }
        }

    }//end Heuristics

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Goal>(out Goal goal))
        {
            Debug.Log("Reward Win!");
            SetReward(+10f);
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
