using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    /// <summary>
    /// �÷��̾��� �Է¿� ���� ���� �μ��� �Լ�
    /// </summary>
    public void Crush()
    {
        gameObject.SetActive(false);
    }
}
