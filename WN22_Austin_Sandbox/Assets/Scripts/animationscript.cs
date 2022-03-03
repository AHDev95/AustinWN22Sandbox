using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationscript : MonoBehaviour
{ 
    
    public Animator animate;

    public void AnimationTrigger()
    {
        if (!animate.GetBool("toggle"))
        {
            animate.SetBool("toggle", true);
            Debug.Log("yes");
        }
        else
        {
            animate.SetBool("toggle", false);
            Debug.Log("no");
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
       


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AnimationTrigger();
        }
        


    }
}
