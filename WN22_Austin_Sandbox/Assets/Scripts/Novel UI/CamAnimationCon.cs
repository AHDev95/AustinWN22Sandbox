using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CamAnimationCon : MonoBehaviour
{
    [SerializeField]
    Animator camPose;

    [SerializeField]
    Slider camSlider;

    [SerializeField]
    int camvalue;


    public void CamPoseSet()
    {

        camvalue = Mathf.RoundToInt(camSlider.value);
        camPose.SetInteger("camPose", camvalue);


    }


    
}
