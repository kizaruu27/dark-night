using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    public Objects keyPadObject, codeDoor;

    [SerializeField] Text Answer;

    public void Number(int number) {
        Answer.text += number.ToString();
    }

    public void Execute() {
        if (Answer.text == keyPadObject.ans) {
            codeDoor.codeDoorOpen = true;
            SoundManager.singleton.playSound(5);
        } else {
            SoundManager.singleton.playSound(6);
        }
    }

    public void ResetPassword() {
        Answer.text = null;
    }
}
