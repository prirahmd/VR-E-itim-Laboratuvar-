using UnityEngine;
using TMPro;

public class AudioToggle : MonoBehaviour
{
    public AudioSource audioSource;
    public TextMeshProUGUI buttonText;

    private bool isMuted = true; // يبدأ صامت

    void Start()
    {
        audioSource.mute = true;

        if (buttonText != null)
        {
            buttonText.text = "🔊 Unmute";
        }
    }

    public void ToggleSound()
    {
        isMuted = !isMuted;
        audioSource.mute = isMuted;

        if (buttonText != null)
        {
            if (isMuted)
                buttonText.text = " Unmute";
            else
                buttonText.text = " Mute";
        }
    }
}