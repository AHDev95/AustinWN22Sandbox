using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColourSlider : MonoBehaviour
{
    public GameObject myObject;

    public MeshRenderer meshColour;

    public Slider red, green, blue;

    public GameObject ScaleObject;

    public Slider ScaleSlider;
    Transform cubeScale;
    Color localcolor;
    Color color;
    // Start is called before the first frame update
    void Start()
    {
       localcolor = myObject.GetComponent<MeshRenderer>().material.color;

        cubeScale = ScaleObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setScale()
    {
        Vector3 newScale = new Vector3(red.value, green.value, blue.value);
        cubeScale.localScale = newScale;


    }

    public void setColour()
    {
        Color color = meshColour.material.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;
        meshColour.material.color = color;
        meshColour.material.SetColor("Emission", color);

    }

    public void ColourSave()
    {
          localcolor = color;
    }
}
