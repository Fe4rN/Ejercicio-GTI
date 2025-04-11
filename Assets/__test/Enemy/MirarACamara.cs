using UnityEngine;

public class MirarACamara : MonoBehaviour
{

    Transform cam;

    void Start()
    {
        cam = Camera.main.transform;
    }

    void Update()
    {
        Vector3 target = cam.position;
        target.y = transform.position.y; // Mantener la altura actual
        transform.LookAt(target); // Mirar hacia la cámara
    }
}
