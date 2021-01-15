using System;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
	private void Awake()
	{
		gameObject.AddComponent<PlayerMovementElement>();
		gameObject.AddComponent<PlayerInputElement>();
	}
}