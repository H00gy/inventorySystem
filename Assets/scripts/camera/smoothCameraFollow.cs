using Unity.VisualScripting;
using UnityEngine;

public class smoothCameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;
    // x clamp
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    // y clamp
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    public Transform target;

    private Vector3 vel = Vector3.zero;

    private float yVelocity = 0f;

    private void Update()
    {
        // X clamp 
        float xValue = Mathf.Sin(transform.position.x);
        float xPos = Mathf.Clamp(xValue, minX, maxX);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        /*
        // Y clamp 
        float yValue = Mathf.Sin(transform.position.y);
        float yPos = Mathf.Clamp(yValue, maxY, minY);
        */

        // clamp transform lock
        //transform.position = new Vector3(xPos, yPos, transform.position.z);

        Vector3 targetPosition = target.position;
        targetPosition.z = transform.position.z; // so camera doesn't move on z axis

        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, damping);

        float newCamY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, damping); // smooth damp to have camera only follow target using y axis
        transform.position = new Vector3 (transform.position.x, newCamY,transform.position.z);
    }
}
