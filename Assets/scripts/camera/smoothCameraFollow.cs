using UnityEngine;

public class smoothCameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;

    public Transform target;

    private Vector3 vel = Vector3.zero;

    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        targetPosition.z = transform.position.z; // so camera doesn't move on z axis

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, damping);
    }
}
