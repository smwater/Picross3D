using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrushMode : MonoBehaviour
{
    [Header ("Sprite")]
    [Tooltip ("�ش��ϴ� ��������Ʈ�� ��������.")]
    [SerializeField] private Sprite _modeOnSprite;

    private Image _image;
    private Sprite _modeOffSprite;

    private void Awake()
    {
        _image = GetComponent<Image>();
        _modeOffSprite = _image.sprite;
    }

    /// <summary>
    /// ��尡 ������ ���� ��������Ʈ�� ��ȯ�ϴ� �Լ�
    /// </summary>
    public void On()
    {
        _image.sprite = _modeOnSprite;
    }

    /// <summary>
    /// ��尡 ������ ���� ��������Ʈ�� ��ȯ�ϴ� �Լ�
    /// </summary>
    public void Off()
    {
        _image.sprite = _modeOffSprite;
    }
}
