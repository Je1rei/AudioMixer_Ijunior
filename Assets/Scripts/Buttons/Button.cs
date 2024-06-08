using System;
using UnityEngine;

public class Button: MonoBehaviour 
{
    public event Action Clicked;

    public virtual void Click()
    {
        Clicked?.Invoke();
    }
}
