using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class change_chief : MonoBehaviour
{
    public int variant;
    int scenario;

    void OnMouseDown()
    {

        if (PlayerPrefs.GetInt("scenario") == variant)
        {
            PlayerPrefs.SetInt("type_of_final", variant);
            SceneManager.LoadScene("final scene");
        }
        else
        {
            PlayerPrefs.SetInt("type_of_final", 6);
            SceneManager.LoadScene("final scene");
        }
    }
}
