using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 20f, Color.black);

        RaycastHit hit;
        int layerMask = 1 << LayerMask.NameToLayer("Block");
        if (Physics.Raycast(ray, out hit, layerMask))
        {
            // 플레이어 입력이 있었다면, 블럭 부수기
        }
    }
}
