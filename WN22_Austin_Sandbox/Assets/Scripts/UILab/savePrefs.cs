using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class savePrefs : MonoBehaviour
{    /* links for class
       https://www.red-gate.com/simple-talk/development/dotnet-development/saving-game-data-with-unity/
      https://gamedevbeginner.com/how-to-use-player-prefs-in-unity/
      */

      public UIData ui;

   //int intToSave;
   //float floatToSave;
   //string stringToSave;

    private void Awake()
    {
        ui = GetComponent<UIData>();
        
    }
    


    public void SaveGame()
    {

        //intToSave = Mathf.RoundToInt(ui.intSlider.value);
      // floatToSave = ui.floatSlider.value;
        //stringToSave = ui.Name.text;

        PlayerPrefs.SetInt("SavedInteger", ui.intToSave);
        PlayerPrefs.SetFloat("SavedFloat", ui.floatToSave);
        PlayerPrefs.SetString("SavedString", ui.stringToSave);
        PlayerPrefs.Save();

        ui.dataText.text = "Your number is " + ui.intToSave.ToString();

        Debug.Log("Game data saved!");
    }

    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            ui.intToSave = PlayerPrefs.GetInt("SavedInteger");
           ui.floatToSave = PlayerPrefs.GetFloat("SavedFloat");
            ui.stringToSave = PlayerPrefs.GetString("SavedString");

            ui.dataText.text = "Hello " + ui.stringToSave + ". Your integer was " + ui.intToSave.ToString() + " and your float was " + ui.floatToSave.ToString();

            ui.intSlider.value = (float)ui.intToSave;

           ui.floatSlider.value = ui.floatToSave;

            Debug.Log("Game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        ui.intToSave = 0;
        ui.floatToSave = 0.0f;
        ui.stringToSave = "";

        ui.dataText.text = "Your number is " + ui.intToSave.ToString();

        ui.intSlider.value = (float)ui.intToSave;

        ui.floatSlider.value = ui.floatToSave;

        Debug.Log("Data reset complete");
    }
}
