using System;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
	private LevelController _levelController;
	private CanvasInventoryElement _canvasInventoryElement;
	private CanvasStatsBarElement _canvasStatsBarElement;
	private bool _isInventory = false;

	private void Awake()
	{
		_canvasInventoryElement = GetComponentInChildren<CanvasInventoryElement>();
		_canvasStatsBarElement = GetComponentInChildren<CanvasStatsBarElement>();
	}

	private void Start()
	{
		_levelController = LevelBlock.Instance.GetLevelController();
		SetInventory(false);
	}

	// Toggles Inventory Mode and Sets Level Mode in Level Controller
	public void ToggleInventory()
	{
		SetInventory(!_isInventory);
	}

	// Sets Inventory Mode and Sets Level Mode in Level Controller
	public void SetInventory(bool mode)
	{
		_isInventory = mode;
		_canvasInventoryElement.gameObject.SetActive(_isInventory);
		if (_isInventory)
		{
			_levelController.SetLevelMode(LevelController.LevelModes.PAUSE);
			return;
		}

		_levelController.SetLevelMode(LevelController.LevelModes.GAMEPLAY);
	}
}