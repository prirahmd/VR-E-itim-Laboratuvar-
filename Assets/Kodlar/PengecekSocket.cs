using UnityEngine;
using TMPro; // Wajib untuk TextMeshPro
using UnityEngine.XR.Interaction.Toolkit;

public class PengecekSocket : MonoBehaviour
{
    [Header("Pengaturan Pengecekan")]
    public string tagYangBenar; // Diisi tag yang seharusnya masuk ke sini
    public TextMeshProUGUI teksLayar; // Tarik teks UI ke sini

    // Fungsi ini dipanggil saat ada benda menempel ke socket
    public void CekObjek(SelectEnterEventArgs args)
    {
        // Mendapatkan benda apa yang baru saja nempel
        GameObject bendaMasuk = args.interactableObject.transform.gameObject;

        // Mengecek apakah benda itu punya label (Tag) yang sesuai
        if (bendaMasuk.CompareTag(tagYangBenar))
        {
            teksLayar.text = "SUPER!";
            teksLayar.color = Color.green;
        }
        else
        {
            teksLayar.text = "TEKRAR DENE!";
            teksLayar.color = Color.red;
        }
    }

    // Fungsi ini dipanggil saat benda dicabut dari socket
    public void HapusTeks(SelectExitEventArgs args)
    {
        teksLayar.text = ""; // Mengosongkan teks saat benda diambil lagi
    }
}