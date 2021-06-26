using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text text;
    private float totaltime = 10f;
    private float _timerCount = 0;

    public bool TimerCount(bool timerStop = false)
    {
        totaltime -= Time.deltaTime;
        _timerCount = totaltime;

        if (_timerCount <= 0)
        {
            _timerCount = 0;
            timerStop = true;
        }
        else
        {
            text.text = _timerCount.ToString("N1") ;
        }

        return timerStop;
    }
}
