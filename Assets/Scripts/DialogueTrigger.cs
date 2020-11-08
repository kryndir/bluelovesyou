using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    public NovelDialogue dialogue;


    public void Start()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 1)
        {
            TriggerDialogue();
        }
    }


    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}

