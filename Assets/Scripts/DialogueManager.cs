using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Animator anim;
    public Text dialogText;
    
    private Queue<string> sentences;
    
    public static DialogueManager instance = null;        

    
    void Awake()
    {
        if (instance == null)          
            instance = this;   
        else if (instance != this)  
            Destroy(gameObject);          
        DontDestroyOnLoad(gameObject);   
    }
    
    void Start()
    {
        sentences = new Queue<string>();
        dialogText = GameObject.FindWithTag("Dialog").GetComponent<Text>();
        anim = GameObject.FindWithTag("AnimDialog").GetComponent<Animator>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerController>().isDialoguing = true;
        anim.SetBool("IsOpen", true);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
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

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    private void EndDialogue()
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerController>().isDialoguing = false;
        anim.SetBool("IsOpen", false);
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
    }
}
