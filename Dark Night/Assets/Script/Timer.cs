using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Objects TimerObject;
    [SerializeField] Text countdownText;
    [SerializeField] GameObject countDownUI;

    void Start()
    {
        TimerObject.currentTime = TimerObject.startingTime;
    }

    void Update()
    {
        TimerObject.currentTime -= 1 * Time.deltaTime;
        countdownText.text = TimerObject.currentTime.ToString("0");

        if (TimerObject.currentTime <= 0) {
            TimerObject.currentTime = 0;
            countDownUI.SetActive(false);
        }
    }
}
