using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerSpawner : MonoBehaviour
{
    public Objects TimerObj;
    public GameObject Killer;
    bool isSpawned;

    private void Start() {
        isSpawned = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (TimerObj.currentTime <= 0) {
            Killer.SetActive(true);
        }
    }
}
