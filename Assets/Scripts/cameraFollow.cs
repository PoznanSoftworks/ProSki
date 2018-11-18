using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // Use this for initialization
    public Transform target;

    public float speedOFCamer = 0.5f;
    public Vector3 distanceToCamera;
    public float rotation;

    private void Start()
    {
        transform.Rotate(rotation,0,0);
    }

    void LateUpdate()
    {
        Vector3 newPosition = target.position + distanceToCamera;
        Vector3 smoothedChangePositionForCamera = Vector3.Lerp(target.position, newPosition, speedOFCamer);
        transform.position = smoothedChangePositionForCamera;
    }
}
