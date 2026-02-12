using System.Collections;
using UnityEngine;
using TMPro; // TextMeshPro support

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;

    public void Show()
    {
        dialoguePanel.SetActive(true);
    }

    public void Hide()
    {
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    public void SetText(string text)
    {
        dialogueText.text = text;
    }
}
