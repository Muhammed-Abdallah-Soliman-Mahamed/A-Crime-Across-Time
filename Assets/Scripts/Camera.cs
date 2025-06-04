using UnityEngine;

public class Camera : MonoBehaviour
{
    public Vector3 offset = Vector3.zero;
    public Transform player;
    public float mouseSensitivity = 100f;
    public float yRotationClamp = 70f;
    public float xRotationClamp = 180f;

    private float _yRotation;
    private float _xRotation;

    void Start()
    {
    }

    void LateUpdate()
    {
        transform.position = player.position + offset;
        transform.rotation = player.rotation;

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        _xRotation += mouseX;
        _yRotation += mouseY;
        _yRotation = Mathf.Clamp(_yRotation, -yRotationClamp, yRotationClamp);
        _xRotation = Mathf.Clamp(_xRotation, -xRotationClamp, xRotationClamp);


        transform.rotation = Quaternion.Euler(-_yRotation, _xRotation, 0);
    }
}
