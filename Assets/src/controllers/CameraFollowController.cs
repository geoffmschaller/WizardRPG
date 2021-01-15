using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    private Transform _target;
    private float _smoothSpeed = 0.125f;
    private Vector3 _offset = new Vector3(0, 10, -10);

    private void Start()
    {
        _target = PlayerBlock.Instance.GetPlayerController().transform;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position + _offset, _smoothSpeed);
        transform.LookAt(_target);
    }
}
