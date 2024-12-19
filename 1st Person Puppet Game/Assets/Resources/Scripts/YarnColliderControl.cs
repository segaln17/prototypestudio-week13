using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnColliderControl : MonoBehaviour
{
    public YarnCollider yarnColliderScript;

    public string changedNodeToCall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("changeNode")]
    public void ChangeNode()
    {
        yarnColliderScript.nodeToCall = changedNodeToCall;
    }
}
