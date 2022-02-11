using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
     public Objects puzzle, door;
     [SerializeField] GameObject doorOpen, doorClosed;
     UIManager uIManager;
     AnimationManager anim;

    private void Start() {
        uIManager = FindObjectOfType<UIManager>();
        anim = FindObjectOfType<AnimationManager>();

        puzzle.puzzleKey = 0;
        puzzle.puzzleKeyPicked = false;
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
}
