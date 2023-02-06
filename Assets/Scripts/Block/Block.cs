using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    /// <summary>
    /// 플레이어의 입력에 따라 블럭을 부수는 함수
    /// </summary>
    public void Crush()
    {
        gameObject.SetActive(false);
    }
}
