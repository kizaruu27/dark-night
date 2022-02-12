using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public Objects keyPadObject;
    [SerializeField] Text Answer;

    public void Number(int number) {
        Answer.text += number.ToString();
    }

    public void Execute() {
        if (Answer.text == keyPadObject.ans) {
            Debug.Log("Password Benar");
        } else {
            Debug.Log("Password Salah");
        }
    }

    public void ResetPassword() {
        Answer.text = null;
    }
}
