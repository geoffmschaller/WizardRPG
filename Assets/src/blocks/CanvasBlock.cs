using System;
using UnityEngine;

public class CanvasBlock : MonoBehaviour
{
	public static CanvasBlock Instance;
	[SerializeField] private Canvas canvasPrefab;
	private CanvasController _canvasController;


	private void Awake()
	{
		Instance = this;
		SpawnCanvas();
	}

	private void SpawnCanvas()
	{
		var spawnedCanvas = Instantiate(canvasPrefab, new Vector3(0, 0, 0), Quaternion.identity);
		_canvasController = spawnedCanvas.GetComponent<CanvasController>();
	}

	public CanvasController GetCanvasController() => _canvasController;
}