using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool isPaused;
    [SerializeField] GameObject pauseUI;

    void Start() {
        isPaused = false;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused) {
          Time.timeScale = 0;
          isPaused = true;
          pauseUI.SetActive(true);

          Cursor.lockState = CursorLockMode.None;
          Cursor.visible = true;

        } else if (Input.GetKeyDown(KeyCode.Escape) && isPaused) {
          Time.timeScale = 1;
          isPaused = false;

          Cursor.lockState = CursorLockMode.Locked;
          Cursor.visible = false;
        }
    }
}
