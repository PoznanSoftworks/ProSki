using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // Use this for initialization
    public Transform target;

    public float speedOFCamer = 0.5f;
    public Vector3 offset;
    public float rotation;

    private void Start()
    {
        transform.Rotate(rotation,0,0);
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(target.position, desiredPosition, speedOFCamer);
        transform.position = smoothedPosition;
    }
}
