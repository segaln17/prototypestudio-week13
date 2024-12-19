using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter_Interacte : MonoBehaviour, IInteractable
{
    public InventoryManager inventoryManager;
    public LetterManager letterManager;
    public GameObject puppetArm;
    public Sprite puppetArmNoLetter;
    public Sprite puppetArmPaper;
    public Sprite puppetArmEnemyLetter;
    public Sprite puppetArmLetter;

    public void Interact()
    {
        Debug.Log("interacting");
        inventoryManager.AddItem(gameObject.name);
        ChangeArm();
        if (gameObject.CompareTag("Paper"))
        {
            if (letterManager.Letters.Count != 0)
            {
                letterManager.Letters.Dequeue();
                Destroy(gameObject, 0.1f);
                letterManager.Letters.Peek().GetComponent<Collider>().enabled = true;
            }
            else if (letterManager.Letters.Count == 0)
            {
                return;
            }
            
        }
    }

    public void ChangeArm()
    {
        if (gameObject.CompareTag("EnemyLetter"))
        {
            puppetArm.GetComponent<SpriteRenderer>().sprite = puppetArmEnemyLetter;
        }

        if (gameObject.CompareTag("MyLetter"))
        {
            puppetArm.GetComponent<Image>().sprite = puppetArmLetter;
        }

        if (gameObject.CompareTag("Paper"))
        {
            puppetArm.GetComponent<Image>().sprite = puppetArmPaper;
        }
        else
        {
            return;
        }
    }
}
