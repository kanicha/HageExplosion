using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text text;
    private float totaltime = 11f;
    private int _timerCount = 0;

    public bool TimerCount(bool timerStop = false)
    {
        totaltime -= Time.deltaTime;
        _timerCount = (int)totaltime;

        if (_timerCount <= -1)
        {
            timerStop = true;
        }
        else
        {
            text.text = _timerCount.ToString() ;
        }

        return timerStop;
    }
}
