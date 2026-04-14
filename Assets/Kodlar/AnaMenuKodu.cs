using UnityEngine;
using UnityEngine.SceneManagement; // Wajib ditambahkan untuk pindah scene

public class PengaturMenu : MonoBehaviour
{
    // Fungsi ini akan dipakai oleh tombol Sınıf, Kuis, dan Laboratuvar
    public void BukaScene(string namaSceneTujuan)
    {
        SceneManager.LoadScene(namaSceneTujuan);
    }

    // Fungsi ini khusus untuk tombol keluar (jika nanti kamu butuh)
    public void KeluarAplikasi()
    {
        Application.Quit();
        Debug.Log("Aplikasi Ditutup");
    }
}