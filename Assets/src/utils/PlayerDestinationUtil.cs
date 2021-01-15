using UnityEngine;

public class PlayerDestinationUtil
{
    private Vector3 _destinationPosition;
    private ItemController _destinationItem;

    public PlayerDestinationUtil(Vector3 destination)
    {
        _destinationPosition = destination;
    }

    public PlayerDestinationUtil(ItemController item)
    {
        _destinationItem = item;
    }

    public ItemController GetDestinationItem() => _destinationItem;
}
