using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuppetFrustration : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip scream;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ExpressFrustration();
        }
    }

    public void ExpressFrustration()
    {
        audioSource.PlayOneShot(scream);
        //maybe also screenshake and everything turns red or something for a second
    }
}
