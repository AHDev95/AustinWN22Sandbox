using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSavePreffs : MonoBehaviour
{
    [SerializeField] UIData_NovelUI uidata;
    [SerializeField]
    Animator cam1, cam2, cam3;


    private void Awake()
    {
        uidata =  GetComponent<UIData_NovelUI>();
    }
   

    public void SaveGame()
    {
        PlayerPrefs.SetInt("cam1Pose", uidata.saveCam1);
        PlayerPrefs.SetInt("cam2Pose", uidata.saveCam2);
        PlayerPrefs.SetInt("cam3Pose", uidata.saveCam3);

        Debug.Log("saved");
    }

    public void LoadGame()
    {
        uidata.saveCam1 = PlayerPrefs.GetInt("cam1Pose");
        cam1.SetInteger("camPose", uidata.saveCam1);

        uidata.saveCam2 = PlayerPrefs.GetInt("cam2Pose");
        cam2.SetInteger("camPose", uidata.saveCam2);

        uidata.saveCam3 = PlayerPrefs.GetInt("cam3Pose");
        cam3.SetInteger("camPose", uidata.saveCam3);

        uidata.camS_1.value = (float)uidata.saveCam1;
        uidata.camS_2.value = (float)uidata.saveCam2;
        uidata.camS_3.value = (float)uidata.saveCam3;



        Debug.Log("loaded");

    }

    public void Resetdata()
    {
        PlayerPrefs.DeleteAll();



    }


    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }


}
