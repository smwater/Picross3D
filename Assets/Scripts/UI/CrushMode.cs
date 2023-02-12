using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrushMode : MonoBehaviour
{
    [Header ("Sprite")]
    [Tooltip ("해당하는 스프라이트를 넣으세요.")]
    [SerializeField] private Sprite _modeOnSprite;

    private Image _image;
    private Sprite _modeOffSprite;

    private void Awake()
    {
        _image = GetComponent<Image>();
        _modeOffSprite = _image.sprite;
    }

    private void OnEnable()
    {
        GameManager.Instance.ModeOff.AddListener(Off);
        GameManager.Instance.CrushModeOn.AddListener(On);
    }

    private void OnDisable()
    {
        GameManager.Instance.ModeOff.RemoveListener(Off);
        GameManager.Instance.CrushModeOn.RemoveListener(On);
    }

    /// <summary>
    /// 모드가 켜졌을 때의 스프라이트로 전환하는 함수
    /// </summary>
    private void On()
    {
        _image.sprite = _modeOnSprite;
    }

    /// <summary>
    /// 모드가 꺼졌을 때의 스프라이트로 전환하는 함수
    /// </summary>
    private void Off()
    {
        _image.sprite = _modeOffSprite;
    }
}
