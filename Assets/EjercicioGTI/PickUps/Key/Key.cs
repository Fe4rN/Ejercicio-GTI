using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    public GameEvent OnKeyCollected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            OnKeyCollected.TriggerEvent();
        }
    }
}
