using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] Text Answer;
    string ans = "123";
    public int digits = 0;
    PuzzleManager puzzleManager;

    public void Number(int number) {
        Answer.text += number.ToString();
    }

    public void Execute() {
        if (Answer.text == ans) {
            Debug.Log("Password Benar");
        } else {
            Debug.Log("Password Salah");
        }
    }

    public void ResetPassword() {
        Answer.text = null;
    }
}
