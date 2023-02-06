using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public enum Mode
    {
        Rotation,
        Crush,
        Protect
    }

    public bool IsClick { get; private set; }
    public Mode NowMode { get; private set; }

    private void Update()
    {
        IsClick = Input.GetMouseButtonDown(0);

        NowMode = Mode.Rotation;

        if (Input.GetKey(KeyCode.Q))
        {
            NowMode = Mode.Crush;
            return;
        }

        if (Input.GetKey(KeyCode.E))
        {
            NowMode = Mode.Protect;
            return;
        }
    }
}
