using UnityEngine;
using UnityEngine.AI;

public class PlayerMovementElement : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private PlayerDestinationUtil _playerDestinationUtil;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.speed = 5.0f;
        _navMeshAgent.stoppingDistance = 0.3f;
    }

    private void Update()
    {
        if (_playerDestinationUtil != null && _navMeshAgent.remainingDistance <= 0.5f)
        {
            var _destinationItem = _playerDestinationUtil.GetDestinationItem();
            if(_destinationItem != null)
                _destinationItem.InteractWithItem();
            _playerDestinationUtil = null;
        }
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
