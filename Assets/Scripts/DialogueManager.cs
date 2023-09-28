using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueManager : MonoBehaviour
{
    public Image DialogueBox;
    public Animator animator;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    public Dialogue dialogue;

    private void Start()
    {
        sentences = new Queue<string>();
    }
 
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        Invoke("EndDialogue", 5);
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
        
    }

    public void DisplayNextSentence()
    {
        if ( sentences .Count == 0)
        {
            EndDialogue();
            return;

        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }


}