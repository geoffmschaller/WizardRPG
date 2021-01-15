using System;
using UnityEngine;
using Object = System.Object;

public class PlayerBlock : MonoBehaviour
{

	public static PlayerBlock Instance;
	private PlayerController _playerController;
	[SerializeField] private GameObject playerPrefab;


	private void Awake()
	{
		Instance = this;
		SpawnPlayer();
	}

	private void SpawnPlayer()
	{
		var spawnedPlayer = Instantiate(playerPrefab, new Vector3(0, 1, 0), Quaternion.identity);
		_playerController = spawnedPlayer.GetComponentInChildren<PlayerController>();
	}

	public PlayerController GetPlayerController() => _playerController;
}
