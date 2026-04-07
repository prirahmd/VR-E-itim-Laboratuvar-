using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class QuizManager : MonoBehaviour
{
    [Header("UI Components")]
    public TMP_Text questionText;
    public Button[] choiceButtons; // Array for 4 buttons (A, B, C, D)

    [Header("Color Settings")]
    public Color normalColor = Color.white;
    public Color correctColor = Color.green;
    public Color wrongColor = Color.red;

    // --- SIMPLE QUIZ DATA ---
    // You can add more questions here later
    private string[] questions = { 
        "1. Güneş sistemimizin merkezi hangisidir?", 
        "2. Dünya'nın uydusu nedir?" 
    };
    
    private string[][] choices = {
        new string[] { "A) Dünya", "B) Ay", "C) Güneş", "D) Yıldız" },
        new string[] { "A) Güneş", "B) Mars", "C) Ay", "D) Venüs" }
    };
    
    // Index of the correct answer (0 = A, 1 = B, 2 = C, 3 = D)
    private int[] correctAnswers = { 2, 2 }; 

    private int currentQuestionIndex = 0;

    void Start()
    {
        DisplayQuestion();
    }

    public void CheckAnswer(int clickedButtonIndex)
    {
        // 1. Disable all buttons temporarily to prevent double clicking
        foreach (Button btn in choiceButtons) btn.interactable = false;

        // 2. Check if the clicked answer is correct
        if (clickedButtonIndex == correctAnswers[currentQuestionIndex])
        {
            // Change clicked button color to green
            choiceButtons[clickedButtonIndex].GetComponent<Image>().color = correctColor;
        }
        else
        {
            // Change clicked button color to red
            choiceButtons[clickedButtonIndex].GetComponent<Image>().color = wrongColor;
            // (Optional) Show the correct answer in green
            choiceButtons[correctAnswers[currentQuestionIndex]].GetComponent<Image>().color = correctColor;
        }

        // 3. Wait for 2 seconds, then transition to the next question
        StartCoroutine(TransitionToNextQuestion());
    }

    IEnumerator TransitionToNextQuestion()
    {
        yield return new WaitForSeconds(2f);

        currentQuestionIndex++;

        if (currentQuestionIndex < questions.Length)
        {
            DisplayQuestion();
        }
        else
        {
            questionText.text = "QUIZ COMPLETED!";
            foreach (Button btn in choiceButtons) btn.gameObject.SetActive(false);
        }
    }

    void DisplayQuestion()
    {
        questionText.text = questions[currentQuestionIndex];
        
        for (int i = 0; i < choiceButtons.Length; i++)
        {
            // Update choice texts (A, B, C, D)
            choiceButtons[i].GetComponentInChildren<TMP_Text>().text = choices[currentQuestionIndex][i];
            // Reset button color to normal
            choiceButtons[i].GetComponent<Image>().color = normalColor;
            // Re-enable button
            choiceButtons[i].interactable = true;
        }
    }
}