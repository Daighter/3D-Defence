using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float zoomSpeed;
    [SerializeField] float pading;

    Vector2 moveDir;
    private float zoomScroll;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void LateUpdate()
    {
        Move();
        Zoom();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * moveDir.y * moveSpeed * Time.deltaTime, Space.World);
        transform.Translate(Vector3.right * moveDir.x * moveSpeed * Time.deltaTime, Space.World);
    }

    private void OnPointer(InputValue value)
    {
        Vector2 mousePOs = value.Get<Vector2>();

        if (mousePOs.x <= pading)
            moveDir.x = -1;
        else if (mousePOs.x >= Screen.width - pading)
            moveDir.x = 1;
        else
            moveDir.x = 0;
        
        if (mousePOs.y <= pading)
            moveDir.y = -1;
        else if (mousePOs.y >= Screen.height - pading)
            moveDir.y = 1;
        else
            moveDir.y = 0;
    }

    private void Zoom()
    {
        transform.Translate(Vector3.forward * zoomSpeed * zoomScroll * Time.deltaTime, Space.Self);
    }

    private void OnZoom(InputValue value)
    {
        zoomScroll = value.Get<Vector2>().y;
    }
}
