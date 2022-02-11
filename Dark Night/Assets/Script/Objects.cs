using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Object")]
public class Objects : ScriptableObject {

    public string description;
    public string objectInteractionText;
    public int keyCount;
    public string doorOpenParameter;
    public string doorCloseParameter;
    public string openDoorInteraction;
    public string closeDoorInteraction;
    public bool doorOpened;
    public bool puzzleKeyPicked;
    public int puzzleKey;
    public string doorMessege;
    public string openPuzzleDoorParameter;
    public string closePuzzleDoorParameter;
}
