using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
     public Objects puzzle, lockedDoor, keyPadObject, qwertyKeypadObject;
     [SerializeField] GameObject doorOpen, doorClosed;
     [SerializeField] Text Notification;
     public GameObject Keypad, qwertyKeypad;
     UIManager uIManager; 
     AnimationManager anim;

    private void Start() {
        Time.timeScale = 1;

        uIManager = FindObjectOfType<UIManager>();
        anim = FindObjectOfType<AnimationManager>();

        puzzle.puzzleKey = 0;
    }

    public void PickUpPuzzleKey() {
        lockedDoor.puzzleKey = 1;
        lockedDoor.puzzleKeyPicked = true;
    }

    public void OpenDoor() {
        if (puzzle.puzzleKeyPicked == true) {
            doorOpen.SetActive(true);
            doorClosed.SetActive(false);
        } else if (puzzle.puzzleKeyPicked == false) {
            uIManager.DoorMessege();
        }
    }

    public void DisplayKeypad() {
        Keypad.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void DisplayQwertyKeypad() {
        qwertyKeypadObject.isUsingQwertyKeypad = true;
        qwertyKeypad.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void DisableKeypad() {
            Keypad.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;   
    }

    public void DisableQwertyKeypad (){
            qwertyKeypad.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;  
    }


 
}
