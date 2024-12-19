using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class RigidbodyController : MonoBehaviour
{
    public Rigidbody door1;

    public Rigidbody door2;

    public Rigidbody wall1;
    public Rigidbody wall2;
    public Rigidbody wall3;
    public Rigidbody wall4;
    public Rigidbody wall5;
    public Rigidbody wall6;
    public Rigidbody wall7;
    public Rigidbody wall8;
    public Rigidbody wall9;

    public Rigidbody candles1;
    public Rigidbody candles2;
    

    public Rigidbody desk;

    public Rigidbody chest;

    public Rigidbody wardrobe;

    public Rigidbody inkwell;

    public Rigidbody planchette;

    public Rigidbody papers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("rigidbodiesOn")]
    public void RigidbodiesOn()
    {
        chest.isKinematic = false;
        desk.isKinematic = false;
        wardrobe.isKinematic = false;
        wall1.isKinematic = false;
        wall2.isKinematic = false;
        wall3.isKinematic = false;
        wall4.isKinematic = false;
        wall5.isKinematic = false;
        wall6.isKinematic = false;
        wall7.isKinematic = false;
        wall8.isKinematic = false;
        wall9.isKinematic = false;
        door1.isKinematic = false;
        door2.isKinematic = false;
        inkwell.isKinematic = false;
        planchette.isKinematic = false;
        papers.isKinematic = false;
        candles1.isKinematic = false;
        candles2.isKinematic = false;
    }
}
