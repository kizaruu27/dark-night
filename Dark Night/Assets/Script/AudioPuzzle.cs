using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPuzzle : MonoBehaviour
{
    [SerializeField] AudioClip[] clips;
    [SerializeField] GameObject Key;
    AudioSource aSource;
    bool musicOneisPlayed = false;
    bool musicTwoisPlayed = false;

    private void Start() {
        aSource = GetComponent<AudioSource>();
    }

    private void Update() {
        Validation();
    }

    public void playMusicOne() {
        aSource.Stop();
        aSource.PlayOneShot(clips[0]);
        musicOneisPlayed = true;
    }

    public void playMusicTwo() {
        aSource.Stop();
        aSource.PlayOneShot(clips[1]);
        musicTwoisPlayed = true;
    }

    public void Validation() {
        if (musicOneisPlayed && musicTwoisPlayed) {
            Key.SetActive(true);
        }
    }

}
