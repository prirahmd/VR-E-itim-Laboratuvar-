using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenuKodu : MonoBehaviour
{
    public void BukaScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
}