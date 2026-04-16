using UnityEngine;
using TMPro;

public class StudentInfoManager : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_InputField studentNumberInputField;
    public TMP_Text warningText;

    public GameObject studentInfoPanel;
    public GameObject quizPanel;

    public QuizManager quizManager;

    public void StartExam()
    {
        string studentName = nameInputField.text.Trim();
        string studentNumber = studentNumberInputField.text.Trim();

        if (string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(studentNumber))
        {
            if (warningText != null)
                warningText.text = "Please enter your name and student number.";
            return;
        }

        if (warningText != null)
            warningText.text = "";

        if (studentInfoPanel != null)
            studentInfoPanel.SetActive(false);

        if (quizPanel != null)
            quizPanel.SetActive(true);

        if (quizManager != null)
            quizManager.StartQuiz(studentName, studentNumber);
    }
}