using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBPlayAnim : MonoBehaviour, IVirtualButtonEventHandler 
{
    public GameObject model;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = model.GetComponent<Animator>();

        /// Register the event handler
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed!");       

        anim.Play("Expand");

        ///throw new System.NotImplementedException();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released!");

        anim.Play("None");

        ///throw new System.NotImplementedException();
    }
}
