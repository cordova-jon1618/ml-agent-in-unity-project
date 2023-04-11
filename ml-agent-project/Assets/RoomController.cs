using UnityEngine;
public class RoomController : MonoBehaviour
{
    // Public variables that can be adjusted in the inspector
    public float minForce = 5f;
    public float maxForce = 10f;

    // This function is called when an object enters the room trigger collider
    void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered has the "Agent" tag
        if (other.gameObject.CompareTag("Agent"))
        {
            // Get all the rigidbodies in the room
            Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
            
            // Loop through each rigidbody and make it affected by physics and gravity
            foreach (Rigidbody rb in rigidbodies)
            {
                rb.isKinematic = false; // Set the rigidbody to be affected by physics
                rb.useGravity = true; // Enable gravity on the rigidbody
                
                // Generate a random force vector to apply to the rigidbody
                Vector3 randomForce = new Vector3(Random.Range(-1f, 1f), Random.Range(1f, 2f), Random.Range(-1f, 1f)) * Random.Range(minForce, maxForce);
                
                // Apply the force to the rigidbody with the Impulse force mode to make it fall in a random direction
                rb.AddForce(randomForce, ForceMode.Impulse);
            }
        }
    }

    // This function is called when an object exits the room trigger collider
    void OnTriggerExit(Collider other)
    {
        // Check if the object that exited has the "Agent" tag
        if (other.gameObject.CompareTag("Agent"))
        {
            // Get all the rigidbodies in the room
            Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
            
            // Loop through each rigidbody and make it not affected by physics or gravity
            foreach (Rigidbody rb in rigidbodies)
            {
                rb.isKinematic = true; // Set the rigidbody to not be affected by physics
                rb.useGravity = false; // Disable gravity on the rigidbody
            }
        }
    }
}
