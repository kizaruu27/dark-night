using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Objects flashlight;
    Light lights;
    void Start()
    {
        flashlight.isTurnOn = true;
        lights = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && flashlight.isTurnOn) {
            lights.intensity = 0;
            flashlight.isTurnOn = false;
        } else if (Input.GetKeyDown(KeyCode.F) && !flashlight.isTurnOn) {
            lights.intensity = flashlight.lightIntensity;
            flashlight.isTurnOn = true;
        }
    }
}
