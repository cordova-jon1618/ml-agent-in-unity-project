using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class Random_Object : Agent
{
    Rigidbody agentRb;
    public float moveSpeed = 10.0f;
    public float jumpForce = 5.0f;
    public float distanceToGround = 0.5f;
    private bool isGrounded = true;

    public override void Initialize()
    {
        agentRb = GetComponent<Rigidbody>();
    }

    public override void OnEpisodeBegin()
    {
        // Reset the agent's position and velocity
        agentRb.velocity = Vector3.zero;
        transform.position = new Vector3(0.0f, 1.0f, 0.0f);
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        // Add the agent's position to the observation
        sensor.AddObservation(transform.position);
    }

    public override void OnActionReceived(ActionBuffers actionBuffers)
    {
        // Move the agent based on the action received
        Vector3 moveDirection = new Vector3(actionBuffers.ContinuousActions[0], 0.0f, actionBuffers.ContinuousActions[1]).normalized;
        agentRb.AddForce(moveDirection * moveSpeed, ForceMode.VelocityChange);

        // Jump if the action calls for it and the agent is on the ground
        if (actionBuffers.DiscreteActions[0] == 1 && isGrounded)
        {
            agentRb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            isGrounded = false;
        }

        // Check if the agent is grounded
        isGrounded = Physics.Raycast(transform.position, Vector3.down, distanceToGround);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Penalty for hitting an obstacle
            AddReward(-1.0f);
            EndEpisode();
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            // Reward for landing on the ground
            AddReward(1.0f);
            isGrounded = true;
        }
    }
}
    