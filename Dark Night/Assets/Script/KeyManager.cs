using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
   [SerializeField] public int keyCount = 0;
   private void Update() {
       if (FindObjectOfType<SelectionManager>().keyPicked == true) {
           keyCount++;
           FindObjectOfType<SelectionManager>().keyPicked = false;
       }
   }
}
