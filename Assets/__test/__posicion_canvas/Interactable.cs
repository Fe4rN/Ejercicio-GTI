using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] string message;
    OverlayMessage overlayMessage;

    private void Awake()
    {
        overlayMessage = FindFirstObjectByType<OverlayMessage>();
    }

    private void OnMouseEnter()
    {
        
        overlayMessage.ShowMessage(message, transform);
    }

    private void OnMouseExit()
    {
        overlayMessage.CleanMessage();
    }

}
