using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundery : MonoBehaviour
{
    [SerializeField] private GameEventA OutOfBoundsEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OutOfBoundsEvent.Raise();
        }
    }
}
