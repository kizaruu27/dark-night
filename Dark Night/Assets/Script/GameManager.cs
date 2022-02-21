using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void ResumeGame() {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void BackToMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame() {
        Application.Quit();
    }
}
