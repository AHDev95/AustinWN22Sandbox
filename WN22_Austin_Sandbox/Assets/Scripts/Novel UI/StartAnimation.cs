using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
   [SerializeField] Animator cam1, cam2, cam3, frank, frankForward;



    public void Action()
    {
        cam1.SetTrigger("start");
        cam2.SetTrigger("start");
        cam3.SetTrigger("start");
        frank.SetTrigger("start");
        frankForward.SetTrigger("start");
    }
   
}
