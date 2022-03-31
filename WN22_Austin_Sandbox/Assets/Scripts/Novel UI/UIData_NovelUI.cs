using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIData_NovelUI : MonoBehaviour
{
    public int saveCam1;
    public int saveCam2;
    public int saveCam3;

    public Slider camS_1, camS_2, camS_3;

    public TextMeshProUGUI cam1Text;
    public TextMeshProUGUI cam2Text;
    public TextMeshProUGUI cam3Text;


    public void CamPosChange()
    {
        saveCam1 = Mathf.RoundToInt(camS_1.value);
        cam1Text.text = "cam_1 pose" + saveCam1.ToString();

        saveCam2 = Mathf.RoundToInt(camS_2.value);
        cam2Text.text = "cam_2 pose" + saveCam2.ToString();

        saveCam3 = Mathf.RoundToInt(camS_3.value);
        cam3Text.text = "cam_3 pose" + saveCam3.ToString();
        Debug.Log("changed");

    }





}
