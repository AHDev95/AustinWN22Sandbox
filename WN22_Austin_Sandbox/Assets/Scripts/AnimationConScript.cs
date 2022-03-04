using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AnimationConScript : MonoBehaviour
{
    public Animator animate;
    public Text toggleLable;
    public TextMeshProUGUI buttonText;


    // Start is called before the first frame update
    void Start()
    {
        if (!animate.GetBool("Start"))
        {
            buttonText.text = "Start";
            Debug.Log("running");
        }
    }
    public void PlayAnimation()
    {
        if (!animate.GetBool("Start")) { 
        animate.SetBool("Start", true);
        buttonText.text = "Stop";
        }  
        else
        {
            animate.SetBool("Start", false);
            buttonText.text = "Start";

        }

        if (!animate.GetBool("toggle"))
        {
            animate.SetBool("toggle", true);
            Debug.Log("yes");
        }

            toggleLable.text = "Bounce";

        
    }

    public void BounceClip()
    {
        if (!animate.GetBool("toggle"))
        {
            animate.SetBool("toggle", true);
            toggleLable.text = "Bounce";
            Debug.Log("yes");
        }
        else
        { 
            animate.SetBool("toggle", false);
            toggleLable.text = "Super Bounce";
            Debug.Log("no");

        }

    }
    
   
}
