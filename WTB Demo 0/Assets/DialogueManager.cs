using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Dialogue[] conversations;
    private int index = 0;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    //public TextMeshPro PreFab;
    public Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        //DialogueTrigger dialogueTrigger = FindObjectOfType<DialogueTrigger>();
        //conversations = dialogueTrigger.conversations;
        sentences = new Queue<string>();
        nameText = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        dialogueText = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    }

    public void StartDialogue(Dialogue conversation)
    {
        sentences.Clear();
        
        //nameText = Instantiate(PreFab);
        nameText.text = conversation.name;

        foreach (string sentence in conversations[index].sentences)
        {
            sentences.Enqueue(sentence);
		}
        DisplayNextSentence();
	}
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
		}
        string output = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(output));
	}
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(.05f);
		}
	}
    public void EndDialogue()
    {
        index++;
        if (index < conversations.Length)
        {
            StartDialogue(conversations[index]);
            return;
        } 
        else
        {
            return;
        }
	}
    public void setIndex(int index)
    {
        this.index = index;
    }
}