using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
  

    private Queue<string> answers1;

    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    public GameObject dialogueBox;
    public GameObject choiceBox;

    public GameObject blueNeutral;
    public GameObject blueBlush;
    public GameObject blueConcerned;
    public GameObject blueFlustered;
    public GameObject blueHappy;

    public int buttonCount;
    public Button replay;
    public Button QuitButton;

    public AudioManager myAudioManager;




    void Start()
    {
        sentences = new Queue<string>();
        buttonCount = 0;


        replay.onClick.AddListener(ReplayListener);
        QuitButton.onClick.AddListener(QuitListener);


    }

    private void Update()
    {
        switch (buttonCount)
        {
            case 1:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 2:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 3:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(true);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 4:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(true);
                break;
            case 5:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(true);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 6:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(true);
                blueHappy.SetActive(false);
                break;
            case 7:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 8:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(true);
                break;
            case 9:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 10:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(true);
                break;
            case 11:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 12:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(true);
                blueHappy.SetActive(false);
                break;
            case 13:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 14:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 15:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(true);
                break;
            case 16:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 17:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 18:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(true);
                blueHappy.SetActive(false);
                break;
            case 19:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(true);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 20:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 21:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(true);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 22:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 23:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(true);
                break;
            case 24:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 25:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 26:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(true);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
            case 27:
                blueBlush.SetActive(false);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(true);
                break;
            default:
                blueBlush.SetActive(true);
                blueConcerned.SetActive(false);
                blueFlustered.SetActive(false);
                blueHappy.SetActive(false);
                break;
        }
    }

    public void StartDialogue(NovelDialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            dialogueBox.SetActive(false);
            choiceBox.SetActive(true);

            EndDialogue();
            return;
        }

            string sentence = sentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));

        buttonCount += 1;
        

    }
    
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.03f); // adjustable
        }

    }

    public void ReplayListener()
    {
        SceneManager.LoadScene(1);

    }
    public void QuitListener()
    {
        SceneManager.LoadScene(0);

    }
    public void EndDialogue()
    {
        animator.SetBool("isOpen", false);
    }
}
