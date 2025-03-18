using UnityEngine;

public class TriggerPuerta : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Messages.Instance.SetText("No tienes la llave");
        }
    }
}
