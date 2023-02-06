using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public enum State
    {
        Normal,
        Crushed,
        Protected
    }

    public State NowState { get; private set; }

    private readonly Color NORMAL_COLOR = Color.white;
    private readonly Color PROTECT_COLOR = Color.yellow;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    /// <summary>
    /// 플레이어의 입력에 따라 블럭을 부수는 함수
    /// </summary>
    public void Crush()
    {
        switch (NowState)
        {
            case State.Normal:
                gameObject.SetActive(false);
                NowState = State.Crushed;
                break;

            default:
                break;
        }
    }

    /// <summary>
    /// 플레이어의 입력에 따라 블럭을 보호하는 함수
    /// </summary>
    public void Protect()
    {
        switch (NowState)
        {
            case State.Normal:
                _renderer.material.color = PROTECT_COLOR;
                NowState = State.Protected;
                break;

            case State.Protected:
                _renderer.material.color = NORMAL_COLOR;
                NowState = State.Normal;
                break;

            default:
                break;
        }
    }
}
