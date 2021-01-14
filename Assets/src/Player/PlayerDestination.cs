using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestination
{

	private ItemBase _itemAtDestination;

	public void SetDestination()
	{
		_itemAtDestination = null;
	}
	
	public void SetDestination(ItemBase item)
	{
		_itemAtDestination = item;
	}

	public void ArriveAtDestination()
	{
		if (_itemAtDestination != null)
		{
			_itemAtDestination.InteractWithItem();
		}
		else
		{
			Debug.Log("Arrived at location!");
		}
	}

}