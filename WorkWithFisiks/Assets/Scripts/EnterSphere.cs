using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using UnityEngine.UI;

public class EnterSphere : MonoBehaviour
{
    [SerializeField] private float _time;
    [SerializeField] private Text _timerText;
    private static bool _flag = false;
    private void OnCollisionEnter(Collision collision)
    {
        EnterText();
    }

    private float _timeLeft = 0f;
    private void EnterText()
    {
        _timeLeft = _time;
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
    }
    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
        {
            flag = true;
            _timeLeft = 0;
        }

        //float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        _timerText.text = string.Format("{00}", seconds);
    }

    public static bool flag { get => _flag; set => _flag = value; }
}
