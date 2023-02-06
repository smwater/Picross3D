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
        int layerMask = 1 << LayerMask.NameToLayer(Optimization.StringBlock);
        if (Physics.Raycast(ray, out hit, layerMask))
        {
            if (_playerInput.IsClick == false)
            {
                return;
            }

            Block block = hit.transform.GetComponent<Block>();

            block.Crush();
        }
    }
}
