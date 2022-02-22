using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{

    public UnityEvent onInteract;
    public Objects objects;

    [Header("Description for Objects")]
    public Text description;

    [Header("Notification for Door")]
    public Text notification;


    public void destroyGameObject() {
        Destroy(gameObject);
    }

    public void displayDescription() {
        description.gameObject.SetActive(true);
        description.text = objects.description;

        if (objects.codeDoorOpen) {
            description.text = objects.openCodeDoorDesc;
        }

        Invoke("disableDesc", 2);
    }

    public void displayNotification() {
        notification.gameObject.SetActive(true);
        notification.text = objects.puzzleKey.ToString();
        
    }

    void disableDesc() {
        description.gameObject.SetActive(false);
    }

    void disableNotification() {
        notification.gameObject.SetActive(false);
    }
 
}
