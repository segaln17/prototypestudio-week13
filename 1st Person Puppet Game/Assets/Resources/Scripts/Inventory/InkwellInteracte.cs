using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InkwellInteracte : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public GameObject puppetArm;
    public Sprite puppetArmLetter;

    public bool inkRadius;

    private void Start()
    {
        inkRadius = false;
    }

    private void Update()
    {
        if (inkRadius)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                ChangeArm();
            }
        }
    }
    /*
    public void Interact()
    {
        Debug.Log("ink");
        //inventoryManager.AddItem(gameObject.name);
        puppetArm.GetComponent<Image>().sprite = puppetArmLetter;
        //Destroy(gameObject, 0.1f);
    }
    */
    
    public void ChangeArm()
    {

        if (gameObject.CompareTag("Ink"))
        {
            //coroutine that plays a timeline?
            //then:
            puppetArm.GetComponent<Image>().sprite = puppetArmLetter;
        }
        else
        {
            return;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        inkRadius = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inkRadius = false;
    }
}
