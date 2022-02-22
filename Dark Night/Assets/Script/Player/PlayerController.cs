using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float baseSpeed = 6f;
    [SerializeField] float speed;
    [SerializeField] float runSpeed = 12f;
    [SerializeField] [Range(0.0f, 0.5f)] float moveSmoothTime = 0.3f;
    [SerializeField] float gravity = -13f;
    CharacterController controller = null;
    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelocity = Vector2.zero;
    float velocityY = 0.0f;
    AudioSource audioSource;
    public bool isMoving;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
        speed = baseSpeed;
    }


    void Update()
    {
        Move();
    }

    void Move() {
        //Movement Input
        Vector2 targetDir = new Vector2 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        targetDir.Normalize();

        //Movement Smoothness
        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, moveSmoothTime);

        //Gravity
        if (controller.isGrounded) {
            velocityY = 0.0f;
        }
        velocityY += gravity * Time.deltaTime;

        //Move
        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * speed + Vector3.up * velocityY; 
        controller.Move(velocity * Time.deltaTime);

        //Player Run
        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = runSpeed;
        } else if (Input.GetKeyUp(KeyCode.LeftShift)) {
            speed = baseSpeed;
        }
    }
}
