using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public Objects objects;

    public UnityEvent onInteract;
    public Text description;

    public void destroyGameObject() {
        Destroy(gameObject);
    }

    public void displayDescription() {
        description.gameObject.SetActive(true);
        description.text = objects.description;
        Invoke("disableDesc", 2);
    }

    void disableDesc() {
        description.gameObject.SetActive(false);
    }
 
}
