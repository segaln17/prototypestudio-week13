using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterManager : MonoBehaviour
{
    public InventoryManager inventoryManager;

    //public Letter_Interacte letterPickUpScript;

    public DepositLetter letterDepositScript;

    public GameObject letter1;

    public GameObject letter2;

    public GameObject letter3;

    public GameObject letter4;

    public Queue<GameObject> Letters = new Queue<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        letter2.GetComponent<Collider>().enabled = false;
        letter3.GetComponent<Collider>().enabled = false;
        letter4.GetComponent<Collider>().enabled = false;
        Letters.Enqueue(letter1);
        Letters.Enqueue(letter2);
        Letters.Enqueue(letter3);
        Letters.Enqueue(letter4);
    }

    // Update is called once per frame
    void Update()
    {
        //if you get a new letter, after you read it,
        //the collider for the next piece of paper turns on
        letterDepositScript.sendText.gameObject.SetActive(false);
    }
}
