using UnityEngine;

public class JumpScareManager : MonoBehaviour
{
   AudioSource audioSource;
   public Objects jumpScareObject;
   public int clips;
   public bool usingSound;
   BoxCollider boxCollider;
   public GameObject zombies;

   private void Start() {
       audioSource = GetComponent<AudioSource>();
       boxCollider = GetComponent<BoxCollider>();
   }

   private void OnTriggerEnter(Collider other) {
       if (other.tag == "Player") { 
           if (usingSound) {
               playSound(clips);
            } else if (!usingSound) {
                zombies.SetActive(true);
                Destroy(zombies, 0.5f);
                playSound(clips);
            }
           boxCollider.enabled = false;
       }
   }

   void playSound(int clips) {
       audioSource.PlayOneShot(jumpScareObject.jumpScareClips[clips]);
   }
}
