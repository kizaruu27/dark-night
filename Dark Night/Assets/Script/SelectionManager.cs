using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] string selectableTag = "Selectable";
    [SerializeField] Material highlightMaterial;
    [SerializeField] Material defaultMaterial;
    [SerializeField] GameObject interactText;
    private Transform _selection;
    UnityEvent onInteract;
    public bool keyPicked = false;
    private void Update() {

        //klo udah gak diarahin
        if (_selection != null) {
            // var selectionRenderer = _selection.GetComponent<Renderer>();
            // selectionRenderer.material = defaultMaterial;
            interactText.SetActive(false);
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
                // var selectionRenderer = selection.GetComponent<Renderer>();
                // if (selectionRenderer != null) {
                //      selectionRenderer.material = highlightMaterial;
                // }
                _selection = selection;
        }
    }
    
}
