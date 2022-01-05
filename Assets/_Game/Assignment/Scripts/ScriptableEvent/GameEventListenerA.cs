using UnityEngine;
using UnityEngine.Events;

public class GameEventListenerA : MonoBehaviour
{
    [SerializeField] private GameEventA Event;
    [SerializeField] private UnityEvent response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        response.Invoke();
    }
}
