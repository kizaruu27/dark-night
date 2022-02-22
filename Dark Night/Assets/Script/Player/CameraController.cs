using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform playerCamera;
    [SerializeField] float camerSensivity = 3.5f;
    [SerializeField] bool lockCursor = true;
    [SerializeField] [Range(0.0f, 0.5f)] float cameraSmoothTime = 0.03f;
    Vector2 currentMouseDelta = Vector2.zero;
    Vector2 currentMouseDeltaVelocity = Vector2.zero;

    float cameraPitch = 0f;

    // Start is called before the first frame update
    void Start()
    {
        if (lockCursor) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        mouseLook();
    }

    void mouseLook() {
        //Mouse Input
        Vector2 targetMouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        //Camera Smoothness
        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetMouseDelta, ref currentMouseDeltaVelocity, cameraSmoothTime);

        //Camera Offset
        cameraPitch -= currentMouseDelta.y * camerSensivity;
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);

        //Vertical Camera
        playerCamera.localEulerAngles = Vector3.right * cameraPitch;

        //Horizontal Camera
        transform.Rotate(Vector3.up * currentMouseDelta.x * camerSensivity);
    }
}
