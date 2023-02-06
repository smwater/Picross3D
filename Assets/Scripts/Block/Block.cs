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
    /// �÷��̾��� �Է¿� ���� ���� �μ��� �Լ�
    /// </summary>
    public void Crush()
    {
        gameObject.SetActive(false);
    }

    /// <summary>
    /// �÷��̾��� �Է¿� ���� ���� ��ȣ�ϴ� �Լ�
    /// </summary>
    public void Protect()
    {
        _renderer.material.color = PROTECT_COLOR;
    }
}
