using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Objects Key, objects, door, puzzleDoor;
    public Text keyUI, description, objectInteraction, DoorPuzzleMessege;
    

    private void Update() {
        KeyUI();
    }

    void KeyUI() {
        keyUI.text = "Owned Key: " + Key.keyCount;
    }

    void turnOffDesc() {
        description.gameObject.SetActive(false);
    }

    public void ObjectInteraction () {
        objectInteraction.gameObject.SetActive(true);
        objectInteraction.text = objects.objectInteractionText;
    }

    public void doorOpenInteraction () {
        objectInteraction.gameObject.SetActive(true);
        objectInteraction.text = door.openDoorInteraction;
    }

    public void doorCloseInteraction () {
        objectInteraction.gameObject.SetActive(true);
        objectInteraction.text = door.closeDoorInteraction;
    }

    public void DoorMessege() {
        DoorPuzzleMessege.gameObject.SetActive(true);
        DoorPuzzleMessege.text = puzzleDoor.doorMessege;
        Invoke("disableMessege", 2);
    }

    void disableMessege() {
        DoorPuzzleMessege.gameObject.SetActive(false);
    }
}
