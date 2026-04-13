using UnityEngine;

public class PlanetMotion : MonoBehaviour
{
    [Header("References")]
    public Transform sun;

    [Header("Realistic Settings")]
    public float orbitPeriodDays = 365f;   // عدد الأيام للدوران حول الشمس
    public float rotationPeriodHours = 24f; // عدد الساعات للدوران حول نفسه

    [Header("Simulation Speed")]
    public float timeScale = 10f; // تسريع الزمن

    void Update()
    {
        if (sun == null) return;

        // 🟠 حساب سرعة الدوران حول الشمس
        float orbitSpeed = 360f / (orbitPeriodDays * 86400f); // درجات/ثانية حقيقية
        orbitSpeed *= timeScale * 86400f; // تسريع الزمن

        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // 🔵 حساب سرعة الدوران حول نفسه
        float rotationSpeed = 360f / (rotationPeriodHours * 3600f);
        rotationSpeed *= timeScale * 3600f;

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}