using UnityEngine;

public class KillerSpawner : MonoBehaviour
{
    public Objects TimerObj;
    public GameObject Killer;


    // Update is called once per frame
    void Update()
    {
        if (TimerObj.currentTime <= 0) {
            Killer.SetActive(true);
        }
    }
}
