using System.Collections;
using System.Collections.Generic;
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

    public void Retry() {
        SceneManager.LoadScene("Gameplay");
    }

    public void PlayGame() {
        SceneManager.LoadScene("Gameplay");
    }

    public void ExitGame() {
        Application.Quit();
    }
}
