using System;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private void Awake()
    {
        gameObject.AddComponent<PlayerMovementElement>();
    }

    public void PlayerArrivedAtDestination(ItemController itemToInteractWith)
    {
        itemToInteractWith.InteractWithItem();
    }

    public void PlayerArrivedAtDestination()
    {
        Debug.Log("Arrived at Location!!!");
    }
}
