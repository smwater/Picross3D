using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
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
        gameObject.SetActive(false);
    }

    /// <summary>
    /// 플레이어의 입력에 따라 블럭을 보호하는 함수
    /// </summary>
    public void Protect()
    {
        _renderer.material.color = PROTECT_COLOR;
    }
}
