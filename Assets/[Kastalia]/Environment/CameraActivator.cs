using Unity.Cinemachine;
using UnityEngine;

public class CameraActivator : MonoBehaviour
{
    [SerializeField] CinemachineCamera cam;

    void OnTriggerEnter(Collider other)
    {
        cam.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        cam.enabled = false;
    }
}
