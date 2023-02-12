using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : SingletoneBehaviour<MonoBehaviour>
{
    public UnityEvent ModeOff = new UnityEvent();
    public UnityEvent CrushModeOn = new UnityEvent();
    public UnityEvent ProtectModeOn = new UnityEvent();
}
