using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text keyUI, objectDescription, objectInteraction;
    KeyManager keyManager;

    private void Awake() {
        keyManager = FindObjectOfType<KeyManager>();
    }
    private void Update() {
        KeyUI();
    }

    void KeyUI() {
        keyUI.text = "Owned Key: " + keyManager.keyCount;
    }

    public void RedCubeDesc() {
        objectDescription.text = "This is a red cube";
        Invoke("turnOffDesc", 2);
    }
    public void GreenCubeDesc() {
        objectDescription.text = "This is a green cube";
        Invoke("turnOffDesc", 2);
    }

    void turnOffDesc() {
        objectDescription.gameObject.SetActive(false);
    }
}
