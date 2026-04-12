using UnityEngine;

public class RotateSun : MonoBehaviour
{
    // Kecepatan rotasi (dalam derajat per detik)
    public float rotationSpeed = 15f;

    // Update is called once per frame
    void Update()
    {
        // Rotasi objek sepanjang sumbu Y (vertikal)
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}