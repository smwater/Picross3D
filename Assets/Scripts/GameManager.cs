using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : SingletoneBehaviour<GameManager>
{
    public UnityEvent ModeOff = new UnityEvent();
    public UnityEvent CrushModeOn = new UnityEvent();
    public UnityEvent ProtectModeOn = new UnityEvent();

    /// <summary>
    /// 클래스 외부에서 GameManager 내부의 이벤트를 구독할 수 있게 만드는 함수
    /// 단, 매개변수가 없는 이벤트만 가능하다.
    /// </summary>
    /// <param name="unityEvent">구독할 이벤트 이름</param>
    public void StartEvent(UnityEvent unityEvent)
    {
        unityEvent.Invoke();
    }
}
