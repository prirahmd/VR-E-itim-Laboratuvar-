using UnityEngine;

public class RobotChatOpener : MonoBehaviour
{
    public GameObject chatbotPanel;
    public GameObject spatialKeyboard;

    public void OpenChat()
    {
        if (chatbotPanel != null)
            chatbotPanel.SetActive(true);

        if (spatialKeyboard != null)
            spatialKeyboard.SetActive(true);
    }
}