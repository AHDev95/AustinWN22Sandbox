using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seriral : MonoBehaviour
{
    public UIData ui;

    int intTosave;
    float floatTosave;
    string stringTosave;


    private void Awake()
    {
        intTosave = ui.intTosave;
        floatTosave = ui.floattosave;
        stringTosave = ui.stringTosave;
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
