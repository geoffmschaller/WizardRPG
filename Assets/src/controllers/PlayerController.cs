using System;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    private NavMeshAgent _navMeshAgent;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        if (Physics.Raycast(CameraBlock.Instance.GetMainCamera().ScreenPointToRay(Input.mousePosition), out var hit, 50))
        {
            _navMeshAgent.destination = hit.point;
        }
    }
}
