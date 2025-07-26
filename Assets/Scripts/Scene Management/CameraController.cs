using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Cinemachine;

public class CameraController : Singleton<CameraController>
{
    private CinemachineCamera cinemachineCamera;

    public void SetPlayerCameraFollow()
    {
        // 
        cinemachineCamera = Object.FindFirstObjectByType<CinemachineCamera>();

        if (cinemachineCamera == null)
        {
            Debug.LogWarning(" CinemachineCamera£¡ is null");
            return;
        }

        // 
        cinemachineCamera.Follow = PlayerController.Instance.transform;
    }
}
