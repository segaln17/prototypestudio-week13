using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InkwellUIScript : MonoBehaviour
{
    public TextMeshProUGUI inkwellUI;
    // Start is called before the first frame update
    void Start()
    {
        inkwellUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inkwellUI.gameObject.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inkwellUI.gameObject.SetActive(false);
        }
        
    }
}
