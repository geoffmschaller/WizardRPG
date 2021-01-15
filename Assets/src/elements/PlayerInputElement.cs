using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputElement : MonoBehaviour
{
	private void Update()
	{
		// Tab: Toggles Player Inventory.
		if (Input.GetKeyUp(KeyCode.Tab))
		{
			CanvasBlock.Instance.GetCanvasController().ToggleInventory();
		}
	}
}