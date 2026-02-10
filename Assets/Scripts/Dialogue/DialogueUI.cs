using System.Collections;
using UnityEngine;
using TMPro; // TextMeshPro support

public class DialogueUI : MonoBehaviour
{
    [Header("Assign your Dialogue Text here")]
    public TMP_Text dialogueText; // Drag the TextMeshProUGUI text here

    [Header("Optional: Dialogue Panel")]
    public GameObject dialoguePanel; // Drag the Dialogue Panel here

    private string[] lines;
    private int currentLine = 0;
    private bool isActive = false;

    void Start()
    {
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);
    }

    void Update()
    {
        if (isActive && Input.GetKeyDown(KeyCode.Space))
        {
            AdvanceDialogue();
        }
    }

    public void StartDialogue(string[] dialogueLines)
    {
        if (dialogueLines == null || dialogueLines.Length == 0) return;

        lines = dialogueLines;
        currentLine = 0;
        isActive = true;

        if (dialoguePanel != null)
            dialoguePanel.SetActive(true);

        ShowCurrentLine();
    }

    private void ShowCurrentLine()
    {
        if (dialogueText != null && currentLine < lines.Length)
        {
            dialogueText.text = lines[currentLine];
        }
    }

    private void AdvanceDialogue()
    {
        currentLine++;
        if (currentLine >= lines.Length)
        {
            EndDialogue();
        }
        else
        {
            ShowCurrentLine();
        }
    }

    public void EndDialogue()
    {
        isActive = false;
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);
        if (dialogueText != null)
            dialogueText.text = "";
    }
}
