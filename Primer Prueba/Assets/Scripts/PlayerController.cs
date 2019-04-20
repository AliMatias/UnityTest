using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float mouseSensitivy = 3f;
    private PlayerMotor motor;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        float xMov = Input.GetAxis("Horizontal");
        float zMov = Input.GetAxis("Vertical");

        Vector3 horMov = transform.right * xMov;
        Vector3 verMov = transform.forward * zMov;

        Vector3 velocity = (horMov + verMov).normalized * speed;

        motor.Move(velocity);

        float yRot = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0f, yRot, 0f) * mouseSensitivy;
        motor.Rotate(rotation);

        float xRot = Input.GetAxis("Mouse Y");
        Vector3 cameraRotation = new Vector3(xRot, 0f, 0f) * mouseSensitivy;
        motor.rotateCamera(cameraRotation);
    }
}
