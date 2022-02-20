using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public Objects soundObject, killerObject;
    public static SoundManager singleton;
    public AudioClip killerClip;
    AudioSource audioSource;
    bool isPlaying;

    private void Awake() {
        audioSource = GetComponent<AudioSource>();
        singleton = this;
    }

    public void playSound(int indexClip) {
        audioSource.PlayOneShot(soundObject.soundEffectClips[indexClip]);
    }

    public void stopSound() {
        audioSource.Stop();
    }
}
