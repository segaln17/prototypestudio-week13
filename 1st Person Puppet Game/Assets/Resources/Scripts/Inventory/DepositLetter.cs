using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DepositLetter : MonoBehaviour
{
    public bool isSent;

    public bool isNearMailbox;
    //public InventoryManager inventoryManager;

    public Letter_Interacte letter1;

    public Letter_Interacte letter2;

    public Letter_Interacte letter3;

    public Letter_Interacte letter4;
    
    public GameObject puppetArm;
    public Sprite puppetArmNoLetter;

    public TextMeshProUGUI sendText;
    // Start is called before the first frame update
    void Start()
    {
        sendText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isNearMailbox)
        {
            sendText.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                isSent = true;
                puppetArm.GetComponent<Image>().sprite = puppetArmNoLetter;
                sendText.gameObject.SetActive(false);
                //coroutine trigger
                //hand changes
                //then the next letter arrives
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isNearMailbox = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isNearMailbox = false;
        isSent = false;
    }
}
