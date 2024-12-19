using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public interface IInteractable
{
    void Interact();
}

public interface IExamining
{
    void Examine();
}
public class Interactor : MonoBehaviour
{

    public Transform InteractorSource;

    public float InteractRange;

    public LayerMask interactableLayer;

    //public AudioSource pickUpChime;
    private Collider[] colliders;

    private List<IInteractable> inventory = new List<IInteractable>();

    public TextMeshProUGUI pickUpText;

    public TextMeshProUGUI readText;
    // Update is called once per frame
    void Update()
    {
        colliders = Physics.OverlapSphere(InteractorSource.position, InteractRange, interactableLayer);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CheckInteracte();
        }
    }

    private void CheckInteracte()
    {
        foreach (Collider collider in colliders)
        {
            if (collider.TryGetComponent<IInteractable>(out var interactObj))
            {
                //if interactable object is within the specified range
                if (IsClose(collider) && !inventory.Contains(interactObj))
                {
                    interactObj.Interact();
                    inventory.Add(interactObj);
                    //play sound?
                }
                else if (collider.TryGetComponent<IExamining>(out var examineObj))
                {
                    examineObj.Examine();
                }
                /*
                else if (!IsClose(collider))
                {
                    pickUpText.gameObject.SetActive(false);
                    readText.gameObject.SetActive(false);
                }
                */
            }
        }
    }

    bool IsClose(Collider collider)
    {
        float distance = Vector3.Distance(InteractorSource.position, collider.transform.position);
        /*
        if (collider.gameObject.CompareTag("MyLetter"))
        {
            //pick up text
            pickUpText.gameObject.SetActive(true);
        }

        if (collider.gameObject.CompareTag("EnemyLetter"))
        {
            readText.gameObject.SetActive(true);
        }
        */
        return distance <= InteractRange;
        
        
    }
}
