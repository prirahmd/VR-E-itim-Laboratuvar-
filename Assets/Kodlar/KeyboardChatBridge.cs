using UnityEngine;
using TMPro;

public class KeyboardChatBridge : MonoBehaviour
{
    public TMP_InputField keyboardInputField;   // Œ«‰… «·ﬂÌ»Ê—œ
    public TMP_InputField questionInputField;   // Œ«‰… «·‘«  «·ﬁœÌ„…

    void Update()
    {
        if (keyboardInputField != null && questionInputField != null)
        {
            if (questionInputField.text != keyboardInputField.text)
            {
                questionInputField.text = keyboardInputField.text;
            }
        }
    }

    public void ClearBoth()
    {
        if (keyboardInputField != null)
            keyboardInputField.text = "";

        if (questionInputField != null)
            questionInputField.text = "";
    }
}