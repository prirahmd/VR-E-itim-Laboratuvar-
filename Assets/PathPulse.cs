using UnityEngine;
using UnityEngine.Video;

public class PlayVideoButton : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void PlayVideo()
    {
        videoPlayer.Play();
    }
}