using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefs_checker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("type_of_final"))
        { }
        else
        {
            PlayerPrefs.SetInt("type_of_final", 0);
        }
        if (PlayerPrefs.HasKey("people_ticker"))
        {}
        else
        {
            PlayerPrefs.SetInt("people_ticker", 0);
        }
        if (PlayerPrefs.HasKey("take_ticker"))
        { }
        else
        {
            PlayerPrefs.SetInt("take_ticker", 0);
        }
        if (PlayerPrefs.HasKey("scenario"))
        { }
        else
        {
            PlayerPrefs.SetInt("scenario", 0);
        }
        if (PlayerPrefs.HasKey("achivement_1"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_1", 0);
        }
        if (PlayerPrefs.HasKey("achivement_2"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_2", 0);
        }
        if (PlayerPrefs.HasKey("achivement_3"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_3", 0);
        }
        if (PlayerPrefs.HasKey("achivement_4"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_4", 0);
        }
        if (PlayerPrefs.HasKey("achivement_5"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_5", 0);
        }
        if (PlayerPrefs.HasKey("achivement_6"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_6", 0);
        }
        if (PlayerPrefs.HasKey("achivement_7"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_7", 0);
        }
        if (PlayerPrefs.HasKey("achivement_8"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_8", 0);
        }
        if (PlayerPrefs.HasKey("achivement_9"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_9", 0);
        }
        if (PlayerPrefs.HasKey("achivement_10"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_10", 0);
        }
        if (PlayerPrefs.HasKey("achivement_11"))
        { }
        else
        {
            PlayerPrefs.SetInt("achivement_11", 0);
        }
    }
}
