using UnityEngine;

public class LevelController : MonoBehaviour
{

    public GameEvent KeyCollectedEvent;

    private void OnEnable()
    {
        if(KeyCollectedEvent != null) KeyCollectedEvent.OnEventTriggered += KeyCollected;
    }


    private void OnDisable()
    {
        KeyCollectedEvent.OnEventTriggered -= KeyCollected;
    }

    public void KeyCollected()
    {
        Debug.Log("Key collected!");
    }
}
