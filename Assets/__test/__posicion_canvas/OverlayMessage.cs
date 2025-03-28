using TMPro;
using UnityEngine;

public class OverlayMessage : MonoBehaviour
{

    TextMeshProUGUI display;
    PinToSceneObject pin;
    private void Start()
    {
        pin = GetComponent<PinToSceneObject>();
        display = GetComponentInChildren<TextMeshProUGUI>();
        CleanMessage();
    }

    public void ShowMessage(string message, Transform obj){
        gameObject.SetActive(true);
        if(pin) pin.SceneObject = obj;
        display.text = message;
    }

    public void CleanMessage(){
        gameObject.SetActive(false);
        if(pin) pin.SceneObject = null;
        display.text = "";
    }
}
