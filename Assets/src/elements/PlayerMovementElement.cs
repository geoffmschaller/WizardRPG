using System;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovementElement : MonoBehaviour
{
	private NavMeshAgent _navMeshAgent;
	private PlayerDestinationUtil _playerDestinationUtil;
	private LevelController _levelController;

	private void Awake()
	{
		_navMeshAgent = GetComponent<NavMeshAgent>();
		_navMeshAgent.speed = 5.0f;
		_navMeshAgent.stoppingDistance = 0.3f;
	}

	private void Start()
	{
		_levelController = LevelBlock.Instance.GetLevelController();
	}

	private void Update()
	{
		// Check if Level Mode is PAUSED.
		if (_levelController.GetLevelMode() == LevelController.LevelModes.PAUSE)
			_navMeshAgent.isStopped = true;
		else
			_navMeshAgent.isStopped = false;
		if (_levelController.GetLevelMode() == LevelController.LevelModes.PAUSE) return;

		// If Player is close, and item is the destination, Interact with it.
		if (_playerDestinationUtil != null && _navMeshAgent.remainingDistance <= 0.25f)
		{
			var destinationItem = _playerDestinationUtil.GetDestinationItem();
			if (destinationItem != null)
				destinationItem.InteractWithItem();
			_playerDestinationUtil = null;
		}

		// Set new Player Destination Util with mouse click.
		if (!Input.GetMouseButtonDown(0)) return;
		if (!Physics.Raycast(CameraBlock.Instance.GetMainCamera().ScreenPointToRay(Input.mousePosition), out var hit,
			50)) return;
		var hitItem = hit.collider.GetComponent<ItemController>();
		if (hitItem != null)
			_playerDestinationUtil = new PlayerDestinationUtil(hitItem);
		else
			_playerDestinationUtil = new PlayerDestinationUtil(hit.point);
		_navMeshAgent.destination = hit.point;
	}
}