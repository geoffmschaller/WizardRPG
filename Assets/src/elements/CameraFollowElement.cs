using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowElement : MonoBehaviour
{
	private Transform _target;
	private const float SmoothSpeed = 0.125f;
	private readonly Vector3 _offset = new Vector3(0, 10, -10);

	private void Start()
	{
		_target = PlayerBlock.Instance.GetPlayerController().transform;
	}

	private void LateUpdate()
	{
		transform.position = Vector3.Lerp(transform.position, _target.position + _offset, SmoothSpeed);
		transform.LookAt(_target);
	}
}