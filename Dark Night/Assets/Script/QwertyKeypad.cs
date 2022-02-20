using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QwertyKeypad : MonoBehaviour
{
    [SerializeField] Text Answer;
    public Objects qwertyKeypad, CodeDoor;
    public void Letter(string letter) {
        Answer.text += letter;
    }

    public void ResetPassword() {
        Answer.text = null;
    }

    public void Execute() {
        if (Answer.text == qwertyKeypad.answer) {
            CodeDoor.codeDoorOpen = true;
            SoundManager.singleton.playSound(5);
        } else {
            SoundManager.singleton.playSound(6);
        }
    }
}
