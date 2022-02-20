using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject GameOverUI;
    private void Start() {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Killer") {
            Time.timeScale = 0;
            GameOverUI.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            SoundManager.singleton.playSound(3);
        }
    }
}
