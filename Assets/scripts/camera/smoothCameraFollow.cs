using Unity.VisualScripting;
using UnityEngine;

public class smoothCameraFollow : MonoBehaviour
{
    /// <summary>
    /// this script is not used in this implementation, but I will keep it in here for potential future usage
    /// function: moves the camera when the assigned object is dragged using the input handler, in this specific script
    /// the cameras position is confined on the X axis.
    /// </summary>
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
        

        Vector3 targetPosition = target.position;
        targetPosition.z = transform.position.z; // so camera doesn't move on z axis


        float newCamY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, damping); // smooth damp to have camera only follow target using y axis
        transform.position = new Vector3(transform.position.x, newCamY, transform.position.z);
    }
}
