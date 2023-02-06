using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool IsClick { get; private set; }

    private void Update()
    {
        IsClick = Input.GetMouseButtonDown(0);
    }
}
