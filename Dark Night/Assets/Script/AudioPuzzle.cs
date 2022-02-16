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
    public void playMusic(int clips) {
        aSource.Stop();
        aSource.PlayOneShot(musicPuzzle.clips[clips]);
    }

    public void playRightMusic(int clips) {
        aSource.Stop();
        aSource.PlayOneShot(musicPuzzle.clips[clips]);
        Debug.Log("This is the right song");
    }



}
