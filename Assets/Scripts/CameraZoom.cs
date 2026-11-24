using UnityEngine;
using Unity.Cinemachine;

public class CameraZoom : MonoBehaviour
{
    public float minDistance = 3f;
    public float maxDistance = 14f;
    public float zoomSpeed = 4f;

    CinemachineThirdPersonFollow follow;

    void Start() => follow = GetComponent<CinemachineThirdPersonFollow>();

    void Update()
    {
        float scroll = Input.mouseScrollDelta.y;
        if (scroll == 0 || follow == null) return;

        follow.CameraDistance = Mathf.Clamp(
            follow.CameraDistance - scroll * zoomSpeed * Time.deltaTime * 10f,
            minDistance, maxDistance);
    }
}