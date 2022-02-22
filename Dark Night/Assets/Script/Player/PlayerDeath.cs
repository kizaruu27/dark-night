using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject GameOverUI;
    private void Start() {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Killer") {
            //Stop Game
            Time.timeScale = 0;

            //Enable Game Over UI
            GameOverUI.SetActive(true);

            //Enable Cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            //Play Sound
            SoundManager.singleton.playSound(3);
        }
    }
}
