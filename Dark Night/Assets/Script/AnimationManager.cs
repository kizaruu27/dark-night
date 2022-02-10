using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator anim;
    string doorOpenParameter = "DoorOpen";
    string doorClosedParameter = "DoorClosed";

    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void DoorOpenAnimation() {
        anim.SetTrigger(doorOpenParameter);
    }

    public void DoorClosedAnimation() {
        anim.SetTrigger(doorClosedParameter);
    }
}
