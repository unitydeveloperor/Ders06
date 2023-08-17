using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseExample : MonoBehaviour
{
    private bool isActive = false;

    private void OnMouseDown()
    {
        isActive = true;
    }

    private void OnMouseDrag()
    {
        
    }

    private void OnMouseUp()
    {
        isActive = false;
    }
}
