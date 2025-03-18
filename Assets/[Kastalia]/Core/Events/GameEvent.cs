using System;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "Events/Game Event")]
public class GameEvent : ScriptableObject
{
    public Action OnEventTriggered;

    public void TriggerEvent()
    {
        OnEventTriggered?.Invoke();
    }
}
