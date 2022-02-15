using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{
    public Objects Key;
    int keyOwned = 0;
    [SerializeField] GameObject EscapeText;
    [SerializeField] Text description;
    Interactable interactable;
    private void Start() {
        Key.keyCount = keyOwned;
        interactable = FindObjectOfType<Interactable>();
    }

    public void pickUpKey() {
        Key.keyCount++;
    }

    public void EscapeHouse() {
        if (Key.keyCount == 5) {
            Time.timeScale = 0;
            EscapeText.SetActive(true);
        } else {
            description.text = Key.description;
        }
    }
}
