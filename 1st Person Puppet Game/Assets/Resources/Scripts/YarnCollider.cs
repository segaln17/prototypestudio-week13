using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using TMPro;

public class YarnCollider : MonoBehaviour
{
    public string nodeToCall;

    public bool inYarnTrigger;

    public bool cutsceneRun;

    private InMemoryVariableStorage _inMemoryVariableStorage;

    public TextMeshProUGUI dialogueIndicator;
    // Start is called before the first frame update
    void Start()
    {
        dialogueIndicator.gameObject.SetActive(false);
        inYarnTrigger = false;
        cutsceneRun = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!cutsceneRun)
        {
            if (FindObjectOfType<DialogueRunner>().IsDialogueRunning == false)
            {
                FindObjectOfType<DialogueRunner>().StartDialogue(nodeToCall);
            }

            cutsceneRun = true;
        }

        else
        {
            if (inYarnTrigger)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("talking");
                    dialogueIndicator.gameObject.SetActive(false);
                    if (FindObjectOfType<DialogueRunner>().IsDialogueRunning == false)
                    {
                        FindObjectOfType<DialogueRunner>().StartDialogue(nodeToCall);
                    }
                }
                
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dialogueIndicator.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inYarnTrigger = true;
            Debug.Log("in yarn trigger");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        dialogueIndicator.gameObject.SetActive(false);
        inYarnTrigger = false;
    }
    
    //variable for nodetocall?
    
}
