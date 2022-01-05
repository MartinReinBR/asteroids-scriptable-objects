using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    //this variable is to make sure the ship doesn't collide with the other collider when wrapping
    private float extraMovement = 0.6f;

    public void WrapScreen()
    {

        Vector3 newPosition = transform.position;

        if(newPosition.x > 1)
        {
            newPosition.x = -newPosition.x + extraMovement;
        }

        else if (newPosition.x < 0)
        {
            newPosition.x = -newPosition.x - extraMovement;
        }

        if (newPosition.y > 1)
        {
            newPosition.y = -newPosition.y + extraMovement;
        }

        else if (newPosition.y < 0)
        {
            newPosition.y = -newPosition.y - extraMovement;
        }

        transform.position = newPosition;
    }
}
