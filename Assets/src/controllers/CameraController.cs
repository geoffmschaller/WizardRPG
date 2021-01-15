using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private CameraFollowElement _cameraFollowElement;

    private void Awake()
    {
        gameObject.AddComponent<CameraFollowElement>();
    }
}
