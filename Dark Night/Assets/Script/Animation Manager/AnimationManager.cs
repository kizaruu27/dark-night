using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator anim;
    public Objects Door;
    bool isOpen;

    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        Door.codeDoorOpen = false;
        isOpen = false;
    }

    private void Update() {
        openCodeDoor();
    }

    public void openDoor () {
        SoundManager.singleton.stopSound();
        SoundManager.singleton.playSound(0);
        anim.Play(Door.doorOpenParameter);
    }

    public void closeDoor() {
        SoundManager.singleton.stopSound();
        SoundManager.singleton.playSound(1);
        anim.Play(Door.doorCloseParameter);
    }

    public void OpenPuzzleDoor() {
        anim.Play(Door.openPuzzleDoorParameter);
    }

    public void ClosePuzzleDoor() {
        anim.Play(Door.closePuzzleDoorParameter);
    }

    public void openCodeDoor() {
        if (Door.codeDoorOpen == true && !isOpen) {
            anim.Play(Door.codedDoorAnimationName);
            SoundManager.singleton.playSound(0);
            isOpen = true;
        }
    }

    public void musicBoxAnimation() {
        Invoke("PlayMusicBox" ,5);
    }

    void PlayMusicBox() {
        anim.Play("MusicBoxAnim");
    }
}
