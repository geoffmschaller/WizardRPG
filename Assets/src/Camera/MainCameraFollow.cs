using UnityEngine;

public class MainCameraFollow : MonoBehaviour
{

    private Transform _target;
    private float _smoothSpeed = 0.125f;
    private Vector3 _offset = new Vector3(0, 10, -10);

    private void Start()
    {
        _target = Player.Instance.transform;
    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = _target.position + _offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(_target);
    }
}
