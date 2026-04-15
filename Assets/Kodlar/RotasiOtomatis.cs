using UnityEngine;

public class RotasiOtomatis : MonoBehaviour
{
    [Header("Pengaturan Gerak")]
    public float kecepatanPutar = 15f;
    public Vector3 sumbuRotasi = Vector3.up; // Default berputar di sumbu Y

    void Update()
    {
        // Berputar secara kontinyu
        transform.Rotate(sumbuRotasi * kecepatanPutar * Time.deltaTime);
    }
}