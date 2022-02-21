using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public Objects doorObject;
    Animator anim;
    AnimationManager animationManager;
    [SerializeField] GameObject doorWarning;

    private void Start() {
        //anim = GetComponent<Animator>();
        animationManager = GetComponent<AnimationManager>();
        //doorObject.puzzleKeyPicked = true;
        doorObject.doorOpened = false;
    }

    public void OpenDoor() {
        if (doorObject.puzzleKeyPicked) {
            if (doorObject.doorOpened == false) {
                animationManager.openDoor();
                doorObject.doorOpened = true;
            } else if (doorObject.doorOpened == true) {
                animationManager.closeDoor();
                doorObject.doorOpened = false;
            }
        } else if (doorObject.puzzleKeyPicked == false) {
            doorWarning.SetActive(true);
        }
    }
}
