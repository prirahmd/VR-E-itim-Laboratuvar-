using UnityEngine;
using UnityEngine.Video;

public class LessonManager : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject slides;
    public GameObject goToLabButton;
    public GameObject yellowPath;

    public MoveToTarget[] students; // 👈 الطلاب

    void Start()
    {
        if (yellowPath != null)
            yellowPath.SetActive(false);

        if (goToLabButton != null)
            goToLabButton.SetActive(false);

        if (video != null)
            video.loopPointReached += VideoFinished;
    }

    public void PlayVideo()
    {
        if (video != null)
            video.Play();
    }

    public void ToggleSlides()
    {
        if (slides != null)
            slides.SetActive(!slides.activeSelf);
    }

    void VideoFinished(VideoPlayer vp)
    {
        if (goToLabButton != null)
            goToLabButton.SetActive(true);
    }

    // 🔥 أهم دالة (زر الذهاب للمختبر)
    public void GoToLab()
    {
        if (yellowPath != null)
            yellowPath.SetActive(true);

        foreach (var s in students)
        {
            if (s != null)
                s.MoveNow();
        }
    }

    public void ForwardVideo()
    {
        if (video != null)
            video.time += 40;
    }

    public void BackVideo()
    {
        if (video != null)
            video.time -= 15;
    }
}