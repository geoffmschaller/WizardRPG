using System;
using UnityEngine;

public class ItemController : MonoBehaviour
{
	private CanvasController _canvasController;

	private void Start()
	{
		_canvasController = CanvasBlock.Instance.GetCanvasController();
	}

	public void InteractWithItem()
	{
		_canvasController.SetInventory(true);
	}
}