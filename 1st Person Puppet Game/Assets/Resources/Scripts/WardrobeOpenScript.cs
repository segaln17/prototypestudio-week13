using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WardrobeOpenScript : MonoBehaviour
{
    public TextMeshProUGUI doorUI;
    public Animator wardrobeAnimator;

    public bool isNearDoor;

    public bool isDoorOpen;
    // Start is called before the first frame update
    void Start()
    {
        isNearDoor = false;
        doorUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isNearDoor)
        {
            if (!isDoorOpen)
            {
                if (Input.GetKeyDown(KeyCode.C))
                {
                    wardrobeAnimator.SetBool("doorOpen", true);
                    isDoorOpen = true;
                }
            }
            
            else if (isDoorOpen)
            {
                wardrobeAnimator.SetBool("doorOpen", false);
                isDoorOpen = false;
            }
            
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isNearDoor = true;
            doorUI.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isNearDoor = false;
            doorUI.gameObject.SetActive(false);
        }
        
    }
}
