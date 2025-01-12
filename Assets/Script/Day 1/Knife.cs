using UnityEngine;

public class KnifeSwipe : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 lastMousePosition;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Detect mouse drag or touch movement
        if (Input.GetMouseButton(0)) // Left mouse button or touch
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Keep it in 2D space

            // Update position of the "knife"
            transform.position = mousePosition;

            // Optional: Draw a debug line
            Debug.DrawLine(lastMousePosition, mousePosition, Color.red, 0.1f);
            lastMousePosition = mousePosition;
        }
    }
}
