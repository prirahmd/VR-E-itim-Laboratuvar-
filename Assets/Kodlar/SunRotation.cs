using UnityEngine;

public class SunRotation : MonoBehaviour
{
    // This variable will appear in the Inspector so you can adjust the speed without opening the script
    public float rotationSpeed = 15f;

    void Update()
    {
        // Rotate the object around the Y-axis (Vector3.up) smoothly
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}