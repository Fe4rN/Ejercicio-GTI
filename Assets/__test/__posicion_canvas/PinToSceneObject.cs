using UnityEngine;

public class PinToSceneObject : MonoBehaviour
{
    [SerializeField] Transform sceneObject;
    RectTransform rectTransform;
    [SerializeField] Camera cam;

    public Transform SceneObject
    {
        get => sceneObject;
        set => sceneObject = value;
    
    }

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        if(cam == null) cam = Camera.main;
    }

    private void LateUpdate()
    {
        if(sceneObject){
            Vector2 pos = cam.WorldToViewportPoint(sceneObject.position);
            rectTransform.anchorMax = pos;
            rectTransform.anchorMin = pos;
        }
    }
}
