using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class UIData : MonoBehaviour
{
    public int savedint;
    public float floatTosave;
    public bool boolTosave;
    public string stringTosave;

    public TextMeshProUGUI intText;
    public TextMeshProUGUI floatText;
    public TextMeshProUGUI dataText;
    

    public Slider floatSlider, intSlider;
    //public Toggle inputBool;

    public TMP_InputField nameString;

    public void changeSliderValue()
    {
        floatTosave = floatSlider.value;
        intTosave = Mathf.RoundToInt(intSlider.value);
        intText.text = intTosave.ToString();
        floatText.text = floatTosave.ToString();
    }

    public void UpdateInfo()
    {
        
    }

    public void DisplayInfo()
    {
        intText.text = intTosave.ToString();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
