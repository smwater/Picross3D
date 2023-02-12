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

        if (Input.GetKey(KeyCode.Q))
        {
            NowMode = Mode.Crush;
            GameManager.Instance.StartEvent(GameManager.Instance.CrushModeOn);
            return;
        }

        if (Input.GetKey(KeyCode.E))
        {
            NowMode = Mode.Protect;
            GameManager.Instance.StartEvent(GameManager.Instance.ProtectModeOn);
            return;
        }

        NowMode = Mode.Rotation;
        GameManager.Instance.StartEvent(GameManager.Instance.ModeOff);
    }
}
