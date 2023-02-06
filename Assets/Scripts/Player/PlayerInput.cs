using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool IsClick { get; private set; }
    public bool RotationMode { get; private set; }
    public bool CrushMode { get; private set; }
    public bool ProtectMode { get; private set; }

    private void Update()
    {
        IsClick = Input.GetMouseButtonDown(0);

        if (!CrushMode && !ProtectMode)
        {
            RotationMode = true;
        }
        else
        {
            RotationMode = false;
        }

        CrushMode = Input.GetKey(KeyCode.Q);
        ProtectMode = Input.GetKey(KeyCode.E);
    }
}
