using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PaperColliderUI : MonoBehaviour
{
    public TextMeshProUGUI paperUI;
    // Start is called before the first frame update
    void Start()
    {
        paperUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("PaperUIOff");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            paperUI.gameObject.SetActive(false);
        }
        
    }

    IEnumerator PaperUIOff()
    {
        paperUI.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        paperUI.gameObject.SetActive(false);
    }
}
