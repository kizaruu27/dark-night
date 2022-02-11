using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectionManager : MonoBehaviour
{
    public Objects door;
    private Transform _selection;
    UnityEvent onInteract;
    UIManager uimanager;
    AnimationManager animationManager;

    private void Awake() {
        uimanager = FindObjectOfType<UIManager>();
        //animationManager = FindObjectOfType<AnimationManager>();
        door.doorOpened = false;
    }

    private void Update() {

        //klo udah gak diarahin
        if (_selection != null) {
            uimanager.objectInteraction.gameObject.SetActive(false);
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //mau ngarahin ke objek
        if (Physics.Raycast(ray, out hit)) {
            var selection = hit.transform;

            if (selection.CompareTag("Selectable")){
                uimanager.ObjectInteraction();
                if (hit.collider.GetComponent<Interactable>() != false) {
                    onInteract = hit.collider.GetComponent<Interactable>().onInteract;
                    if (Input.GetKey(KeyCode.E)) {
                        onInteract.Invoke();
                    }
                }
            }

            if (selection.CompareTag("Door")) {
                
                if (door.doorOpened == false) {
                    uimanager.doorOpenInteraction();
                } else {
                    uimanager.doorCloseInteraction();
                }

                if (hit.collider.GetComponent<Interactable>() != false) {
                    onInteract = hit.collider.GetComponent<Interactable>().onInteract;
                    animationManager = hit.collider.GetComponent<AnimationManager>();
                    if (Input.GetKeyDown(KeyCode.E)) {
                        if (door.doorOpened == false) {
                            onInteract.Invoke();
                            animationManager.openDoor();
                            door.doorOpened = true;
                        } else if (door.doorOpened == true) {
                            onInteract.Invoke();
                            animationManager.closeDoor();
                            door.doorOpened = false;
                        }
                    }
                }
            }
                _selection = selection;
        }
    }
    
}
