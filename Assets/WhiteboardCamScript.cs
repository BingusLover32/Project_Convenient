using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteboardCamScript : MonoBehaviour
{
    public Transform targetPosition; // The target position for the camera
    public Transform targetLookAt; // The target point the camera should look at
    public Transform OriginalPosition;
    public Transform OriginalLookAt;
    public float moveSpeed = 5f; // Speed at which the camera moves
    public float rotationSpeed = 3f; // Speed at which the camera rotates
    private bool isAtTarget = false; // Flag to check if the camera is at the target position

    public void ActivateIt();
    {
        isAtTarget = !isAtTarget;
    }
    
    void Update()
    {

        // Move the camera towards the target position
        if (isAtTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
            // Rotate the camera to look at the target point
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetLookAt.position - transform.position), rotationSpeed * Time.deltaTime);
        }
        // Move the camera back to its original position
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.parent.position, moveSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(OriginalLookAt.position - transform.position), rotationSpeed * Time.deltaTime);
        }

        
    }
}
