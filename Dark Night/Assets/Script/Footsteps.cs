using UnityEngine;

public class Footsteps : MonoBehaviour
{
    CharacterController characterController;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded == true && characterController.velocity.magnitude > 2 && audioSource.isPlaying == false) {
            audioSource.volume = Random.Range(0.8f, 1f);
            audioSource.pitch = Random.Range(0.8f, 1.1f);
            audioSource.Play();
        }
    }
}
