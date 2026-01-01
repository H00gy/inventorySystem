using UnityEngine;

public class smoothCameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;

    public Transform target;

    private Vector3 vel = Vector3.zero;

    private float yVelocity = 0f;

    private void Update()
    {
        // clamp 
        float xValue = Mathf.Sin(transform.position.x);
        float xPos = Mathf.Clamp(xValue, minX, maxX);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

        Vector3 targetPosition = target.position;
        targetPosition.z = transform.position.z; // so camera doesn't move on z axis

        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, damping);
        float newCamY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, damping);
        transform.position = new Vector3 (transform.position.x, newCamY,transform.position.z);
    }
}
