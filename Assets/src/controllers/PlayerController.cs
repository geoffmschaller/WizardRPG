using System;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    private PlayerMovementElement _playerMovementElement;

    private void Awake()
    {
        gameObject.AddComponent<PlayerMovementElement>();
    }
}
