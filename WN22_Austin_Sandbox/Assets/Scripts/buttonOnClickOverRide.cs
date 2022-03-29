using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonOnClickOverRide : MonoBehaviour
{
    [SerializeField]
    GameObject button;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("fingerTip"))
        {
            button.GetComponent<Button>().onClick.Invoke();

        }

    }


}
