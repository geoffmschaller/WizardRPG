using System;
using UnityEngine;

public class CameraBlock : MonoBehaviour
{
	public static CameraBlock Instance;
	private Camera _mainCamera;
	[SerializeField] private Camera _cameraPrefab;

	private void Awake()
	{
		Instance = this;
		SpawnCamera();
		_mainCamera = Camera.main;
	}

	private void SpawnCamera()
	{
		Instantiate(_cameraPrefab, new Vector3(0, 10, -10), Quaternion.identity);
	}

	public Camera GetMainCamera() => _mainCamera;
}