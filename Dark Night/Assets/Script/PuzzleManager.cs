using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
     public Objects puzzle, door;
     [SerializeField] GameObject doorOpen, doorClosed;
     public GameObject Keypad;
     UIManager uIManager;
     AnimationManager anim;
     public bool isUsingKeypad;

    private void Start() {
        Time.timeScale = 1;

        uIManager = FindObjectOfType<UIManager>();
        anim = FindObjectOfType<AnimationManager>();

        puzzle.puzzleKey = 0;
        puzzle.puzzleKeyPicked = false;
    }

    private void Update() {
        DisableKeypad();
    }

    public void PickUpPuzzleKey() {
        puzzle.puzzleKey++;
        puzzle.puzzleKeyPicked = true;
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
        isUsingKeypad = true;
        Keypad.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void DisableKeypad() {
        if (Input.GetKey(KeyCode.Escape) && isUsingKeypad) {
            isUsingKeypad = false;
            Keypad.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;   
        }
    }
}
