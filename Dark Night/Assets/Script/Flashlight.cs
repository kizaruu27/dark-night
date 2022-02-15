using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Objects flashlight;
    Light light;
    void Start()
    {
        flashlight.isTurnOn = true;
        light = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && flashlight.isTurnOn) {
            light.intensity = 0;
            flashlight.isTurnOn = false;
        } else if (Input.GetKeyDown(KeyCode.F) && !flashlight.isTurnOn) {
            light.intensity = flashlight.lightIntensity;
            flashlight.isTurnOn = true;
        }
    }
}
