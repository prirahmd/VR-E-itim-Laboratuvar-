using UnityEngine;
using UnityEngine.UI;

public class SlideManager : MonoBehaviour
{
    public Image slideImage;
    public Sprite[] slides;

    int currentSlide = 0;

    void Start()
    {
        slideImage.sprite = slides[currentSlide];
    }

    public void NextSlide()
    {
        if (currentSlide < slides.Length - 1)
        {
            currentSlide++;
            slideImage.sprite = slides[currentSlide];
        }
    }

    public void PreviousSlide()
    {
        if (currentSlide > 0)
        {
            currentSlide--;
            slideImage.sprite = slides[currentSlide];
        }
    }
}