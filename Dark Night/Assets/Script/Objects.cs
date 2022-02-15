﻿using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Object")]
public class Objects : ScriptableObject {

    [Header("Interactable Objects")]
    public string description;
    public string objectInteractionText;

    [Header("Key")]
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
    public string openPuzzleDoorParameter;
    public string closePuzzleDoorParameter;
    
    [Header("Keypad")]
    public string ans;
    public bool isUsingKeypad;

    [Header("Music Puzzle")]
    public AudioClip[] clips;
    public bool musicOneisPlayed;
    public bool musicTwoisPlayed;

    [Header("Flashlight")]
    public float lightIntensity;
    public bool isTurnOn;

}
