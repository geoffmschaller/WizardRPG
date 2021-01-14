using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public static Player Instance;
    private NavMeshAgent _navMeshAgent;
    private Camera _playerCamera;
    private PlayerDestination _playerDestination;

    private void Awake()
    {
        Instance = this;
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        _playerCamera = Camera.main;
    }

    private void Update()
    {
        if (_playerDestination != null && _navMeshAgent.remainingDistance <= 0.5)
        {
            _playerDestination.ArriveAtDestination();
            _playerDestination = null;
        }

        if (!Input.GetMouseButtonDown(0)) return;
        RaycastHit hit;
        if (!Physics.Raycast(_playerCamera.ScreenPointToRay(Input.mousePosition), out hit, 100)) return;
        ItemBase _hitItem = hit.collider.GetComponentInChildren<ItemBase>();
        _playerDestination = new PlayerDestination();
        _playerDestination.SetDestination();
        if (_hitItem != null)
            _playerDestination.SetDestination(_hitItem);
        _navMeshAgent.destination = hit.point;
        
    }
}
