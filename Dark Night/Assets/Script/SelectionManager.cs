using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] string selectableTag = "Selectable";
    [SerializeField] Material highlightMaterial;
    [SerializeField] Material defaultMaterial;
    [SerializeField] GameObject interactText, doorOpenText;
    private Transform _selection;
    UnityEvent onInteract;
    public bool keyPicked = false;
    bool doorOpened = false;
    private void Update() {

        //klo udah gak diarahin
        if (_selection != null) {
            interactText.SetActive(false);
            doorOpenText.SetActive(false);
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //mau ngarahin ke objek
        if (Physics.Raycast(ray, out hit)) {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag)){
                interactText.SetActive(true);
                if (hit.collider.GetComponent<Interactable>() != false) {
                    onInteract = hit.collider.GetComponent<Interactable>().onInteract;
                    if (Input.GetKey(KeyCode.E)) {
                        onInteract.Invoke();
                    }
                }
            }
            if (selection.CompareTag("Key")) {
                interactText.SetActive(true);
                if (hit.collider.GetComponent<Interactable>() != false) {
                    onInteract = hit.collider.GetComponent<Interactable>().onInteract;
                    if (Input.GetKey(KeyCode.E)) {
                        keyPicked = true;
                        onInteract.Invoke();
                    }
                }
            }
            if (selection.CompareTag("Cube Merah")) {
                interactText.SetActive(true);
                if (hit.collider.GetComponent<Interactable>() != false) {
                    onInteract = hit.collider.GetComponent<Interactable>().onInteract;
                    if (Input.GetKey(KeyCode.E)) {
                        onInteract.Invoke();
                    }
                }
            }
            if (selection.CompareTag("Cube Hijau")) {
                interactText.SetActive(true);
                if (hit.collider.GetComponent<Interactable>() != false) {
                    onInteract = hit.collider.GetComponent<Interactable>().onInteract;
                    if (Input.GetKey(KeyCode.E)) {
                        onInteract.Invoke();
                    }
                }
            }
            if (selection.CompareTag("Door")) {
                doorOpenText.SetActive(true);
                if (hit.collider.GetComponent<Interactable>() != false) {
                    onInteract = hit.collider.GetComponent<Interactable>().onInteract;
                    if (Input.GetKeyDown(KeyCode.E)) {
                        if (!doorOpened) {
                            onInteract.Invoke();
                            FindObjectOfType<AnimationManager>().anim.Play("OpenDoorAnimation");
                            doorOpened = true;
                        } else if (doorOpened) {
                            onInteract.Invoke();
                            FindObjectOfType<AnimationManager>().anim.Play("CloseDoorAnimation");
                            doorOpened = false;
                        }
                    } 
                }
            }
                _selection = selection;
        }
    }
    
}
