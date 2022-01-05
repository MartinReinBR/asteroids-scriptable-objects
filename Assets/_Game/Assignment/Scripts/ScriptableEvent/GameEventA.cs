using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEventA : ScriptableObject
{
    private List<GameEventListenerA> _listeners = new List<GameEventListenerA>();

    public void Raise()
    {
        for (int i = _listeners.Count - 1; i >= 0; i--)
        {
            _listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(GameEventListenerA listener)
    {
        _listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListenerA listener)
    {
        _listeners.Remove(listener);
    }
}
