using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Object")]
public class Objects : ScriptableObject {

    [Header("Interactable Objects")]
    public string description;
    public string objectInteractionText;

    [Header("1ey")]
    public int keyCount;
    public string keyWarning;

    [Header("Door")]
    public string doorOpenParameter;
    public string doorCloseParameter;
    public string openDoorInteraction;
    public string closeDoorInteraction;
    public bool doorOpened;

    [Header("Puzzle Door")]
    public bool puzzleKeyPicked;
    public int puzzleKey;
    public string doorMessege;
    public string KeyNotification;
    public string DoorNotification;
    public string openPuzzleDoorParameter;
    public string closePuzzleDoorParameter;
    
    [Header("Keypad")]
    public string ans;
    public bool isUsingKeypad;

    [Header("QwertyKeypad")]
    public string answer;
    public bool isUsingQwertyKeypad;

    [Header("Music Puzzle")]
    public AudioClip[] clips;
    public bool musicOneisPlayed;
    public bool musicTwoisPlayed;

    [Header("Flashlight")]
    public float lightIntensity;
    public bool isTurnOn;

    [Header("CodedDoor")]
    public string codedDoorAnimationName;
    public bool codeDoorOpen;
    public string openCodeDoorDesc;

    [Header("GameOver")]
    public bool isDeath;

    [Header("Jumpscares")]
    public AudioClip[] jumpScareClips;

    [Header("Sound Effect")]
    public AudioClip[] soundEffectClips;

    [Header("Killer")]
    public bool isChasing;
   

}
