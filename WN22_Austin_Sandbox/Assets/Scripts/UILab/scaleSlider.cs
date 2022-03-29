using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scaleSlider : MonoBehaviour
{
    public GameObject ScaleObject;

    public Slider ScaleSlider;

    Transform cubeScale;
    // Start is called before the first frame update
    void Start()
    {
        cubeScale = ScaleObject.GetComponent<Transform>();
    }

    public void setScale()
    {
        Vector3 newScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
        cubeScale.localScale = newScale;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
