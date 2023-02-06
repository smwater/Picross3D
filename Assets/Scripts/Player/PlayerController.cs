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
        int layerMask = 1 << LayerMask.NameToLayer(Optimization.STRING_BLOCK);
        // Block에 한해서만 동작하도록 레이어 마스크 사용
        if (Physics.Raycast(ray, out hit, layerMask))
        {
            // 플레이어 입력이 없다면 반환
            if (_playerInput.IsClick == false)
            {
                return;
            }

            Block block = hit.transform.GetComponent<Block>();

            if (_playerInput.NowMode == PlayerInput.Mode.Crush)
            {
                block.Crush();
            }

            if (_playerInput.NowMode == PlayerInput.Mode.Protect)
            {
                block.Protect();
            }
        }
    }
}
