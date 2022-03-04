using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationscript : MonoBehaviour
{ 
    
    public Animator animate;
    [SerializeField] string parameterName;

    [SerializeField] bool hasTrigger = false;
    [SerializeField] bool hasFloat= false;
    [SerializeField] bool hasInt = false;
    [SerializeField] bool hasBool = false;
    
    public void AnimationTrigger()
    { 
        if (hasTrigger) //for triggers
        {

            animate.SetTrigger(parameterName);
            Debug.Log("tigger set off");
        }
       

        if (hasBool) //for bools
        {


            if (!animate.GetBool(parameterName))
            {
                animate.SetBool(parameterName, true);
                Debug.Log("yes");
            }
            else
            {
                animate.SetBool(parameterName, false);
                Debug.Log("no");
            }

        }

        if (hasInt)
        {
            Debug.Log("int");
        }

        if (hasFloat)
        {
            Debug.Log("float");
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
