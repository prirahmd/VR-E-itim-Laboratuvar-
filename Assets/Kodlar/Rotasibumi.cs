using UnityEngine;

public class Rotasibumi : MonoBehaviour
{
    [Header("Pengaturan Rotasi")]
    [Tooltip("Kecepatan rotasi planet")]
    public float kecepatan = 20.0f;

    [Tooltip("Arah rotasi (Default: Y untuk berputar ke samping)")]
    public Vector3 sumbuRotasi = Vector3.up;

    void Update()
    {
        // Berputar berdasarkan waktu nyata agar halus
        transform.Rotate(sumbuRotasi, kecepatan * Time.deltaTime);
    }
}