using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPuzzle : MonoBehaviour
{
    public Objects musicPuzzle;
    [SerializeField] GameObject Key;
    AudioSource aSource;

    private void Start() {
        aSource = GetComponent<AudioSource>();
        musicPuzzle.musicOneisPlayed = false;
        musicPuzzle.musicTwoisPlayed = false;
    }

    private void Update() {
        Validation();
    }

    public void playMusicOne() {
        aSource.Stop();
        aSource.PlayOneShot(musicPuzzle.clips[0]);
        musicPuzzle.musicOneisPlayed = true;
    }

    public void playMusicTwo() {
        aSource.Stop();
        aSource.PlayOneShot(musicPuzzle.clips[1]);
        musicPuzzle.musicTwoisPlayed = true;
    }

    public void Validation() {
        if (musicPuzzle.musicOneisPlayed && musicPuzzle.musicTwoisPlayed) {
            Key.SetActive(true);
        }
    }

}
