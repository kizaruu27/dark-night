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
        Vector2 targetMouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        currentMouseDelta = Vector2.SmoothDamp(currentMouseDelta, targetMouseDelta, ref currentMouseDeltaVelocity, cameraSmoothTime);
        cameraPitch -= currentMouseDelta.y * camerSensivity;
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);

        playerCamera.localEulerAngles = Vector3.right * cameraPitch;

        transform.Rotate(Vector3.up * currentMouseDelta.x * camerSensivity);
    }
}
