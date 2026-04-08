using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class QuizManager : MonoBehaviour
{
    [Header("UI Components")]
    public TMP_Text questionText;
    public Button[] choiceButtons; // A, B, C, D
    public TMP_Text resultText;
    public GameObject restartButton;

    [Header("Colors")]
    public Color normalColor = Color.white;
    public Color correctColor = Color.green;
    public Color wrongColor = Color.red;

    [Header("Quiz Settings")]
    public float nextQuestionDelay = 2f;

    private string[] questions = {
        "Gunes sistemimizin merkezi hangisidir?",
        "Gunes sisteminde kac gezegen vardir?",
        "Gunes nedir?",
        "Gunes'in yasi yaklasik ne kadardir?",
        "Dunya Gunes'e kacinci gezegendir?",
        "Dunya'nin yuzeyinin yaklasik yuzde kaci sudur?",
        "Dunya'nin uydusu nedir?",
        "Ay ne yaparak gorunur?",
        "Ay Dunya etrafindaki turunu kac gunde tamamlar?",
        "Gunes olmasaydi ne olurdu?"
    };

    private string[][] choices = {
        new string[] { "A) Dunya", "B) Ay", "C) Gunes", "D) Mars" },
        new string[] { "A) 7", "B) 8", "C) 9", "D) 10" },
        new string[] { "A) Gezegen", "B) Yildiz", "C) Uydu", "D) Asteroit" },
        new string[] { "A) 1 milyar", "B) 4.6 milyar", "C) 10 milyar", "D) 100 milyon" },
        new string[] { "A) 1", "B) 2", "C) 3", "D) 4" },
        new string[] { "A) %50", "B) %30", "C) %70", "D) %90" },
        new string[] { "A) Gunes", "B) Mars", "C) Ay", "D) Venus" },
        new string[] { "A) Isik yayarak", "B) Gunes isigini yansitarak", "C) Kendi isigiyla", "D) Karanlik olarak" },
        new string[] { "A) 7 gun", "B) 27 gun", "C) 365 gun", "D) 100 gun" },
        new string[] { "A) Hicbir sey olmazdi", "B) Hayat olmazdi", "C) Daha sicak olurdu", "D) Daha hizli donerdi" }
    };

    // 0=A, 1=B, 2=C, 3=D
    private int[] correctAnswers = {
        2, // Gunes
        1, // 8
        1, // Yildiz
        1, // 4.6 milyar
        2, // 3
        2, // %70
        2, // Ay
        1, // Gunes isigini yansitarak
        1, // 27 gun
        1  // Hayat olmazdi
    };

    private int currentQuestionIndex = 0;
    private int score = 0;
    private bool isAnswering = false;

    void Start()
    {
        InitializeQuiz();
    }

    void InitializeQuiz()
    {
        currentQuestionIndex = 0;
        score = 0;
        isAnswering = false;

        if (resultText != null)
            resultText.text = "";

        if (restartButton != null)
            restartButton.SetActive(false);

        foreach (Button btn in choiceButtons)
            btn.gameObject.SetActive(true);

        DisplayQuestion();
    }

    void DisplayQuestion()
    {
        if (questionText != null)
            questionText.text = questions[currentQuestionIndex];

        for (int i = 0; i < choiceButtons.Length; i++)
        {
            TMP_Text btnText = choiceButtons[i].GetComponentInChildren<TMP_Text>();
            Image btnImage = choiceButtons[i].GetComponent<Image>();

            if (btnText != null)
                btnText.text = choices[currentQuestionIndex][i];

            if (btnImage != null)
                btnImage.color = normalColor;

            choiceButtons[i].interactable = true;
        }
    }

    public void CheckAnswer(int clickedButtonIndex)
    {
        if (isAnswering)
            return;

        isAnswering = true;

        foreach (Button btn in choiceButtons)
            btn.interactable = false;

        int correctIndex = correctAnswers[currentQuestionIndex];

        if (clickedButtonIndex == correctIndex)
        {
            Image clickedImage = choiceButtons[clickedButtonIndex].GetComponent<Image>();
            if (clickedImage != null)
                clickedImage.color = correctColor;

            score++;
        }
        else
        {
            Image clickedImage = choiceButtons[clickedButtonIndex].GetComponent<Image>();
            if (clickedImage != null)
                clickedImage.color = wrongColor;

            Image correctImage = choiceButtons[correctIndex].GetComponent<Image>();
            if (correctImage != null)
                correctImage.color = correctColor;
        }

        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(nextQuestionDelay);

        currentQuestionIndex++;

        if (currentQuestionIndex < questions.Length)
        {
            isAnswering = false;
            DisplayQuestion();
        }
        else
        {
            ShowFinalResult();
        }
    }

    void ShowFinalResult()
    {
        if (questionText != null)
            questionText.text = "QUIZ COMPLETED";

        foreach (Button btn in choiceButtons)
            btn.gameObject.SetActive(false);

        string rating;
        if (score == questions.Length)
            rating = "Excellent";
        else if (score >= questions.Length * 0.7f)
            rating = "Very Good";
        else if (score >= questions.Length * 0.5f)
            rating = "Good";
        else
            rating = "Try Again";

        if (resultText != null)
            resultText.text = "Score: " + score + " / " + questions.Length + "\n" + rating;

        if (restartButton != null)
            restartButton.SetActive(true);
    }

    public void RestartQuiz()
    {
        InitializeQuiz();
    }
}