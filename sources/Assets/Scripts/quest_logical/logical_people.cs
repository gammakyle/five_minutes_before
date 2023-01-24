using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logical_people : MonoBehaviour
{
    public bool check = false;
    private GameObject EventSystem;

    void OnMouseDown()
    {
        if (check == false)
        {
            EventSystem = GameObject.Find("EventSystem");
            EventSystem.GetComponent<timerscript>().people_ticker += 1;
            check = true;
        }
    }
}
