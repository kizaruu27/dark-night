using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public Objects Key;
    int keyOwned = 0;

    //[SerializeField] public int keyCount = 0;
    private void Start() {
        Key.keyCount = keyOwned;
    }

    public void pickUpKey() {
        Key.keyCount++;
    }
}
