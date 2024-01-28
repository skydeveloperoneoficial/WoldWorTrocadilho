using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text nameText;
     public Text dialogueText;
    private Queue<string> sentences;// fila de sentenca
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public  void StartDialog(Dialog dialog)
    {
        nameText.text = dialog.name;
        //Debug.Log("Fufando: "+dialog.name);
        sentences.Clear();
        foreach (string sentence in dialog.senteces)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentece();
    }
    private IEnumerator TypeSentece(string sentence)
        {
            
            dialogueText.text ="";// limpar o texto
           
            foreach (char leter in sentence)
            {
                dialogueText.text += leter;
                
                yield return null;
            }
        }
    public  void DisplayNextSentece()
    {
        if(sentences.Count== 0)
        {
            EnDialog();
             return;
        }
        string sentence= sentences.Dequeue();
        //Debug.Log(sentence);
        //dialogueText.text =sentence;

        StopAllCoroutines();
        StartCoroutine(TypeSentece(sentence));

    }
    
    private void EnDialog()
    {
        Debug.Log("end Dialog");
    }
}
