using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startnewgame : MonoBehaviour
{
    int variant = 0;

    void OnMouseDown()
    {
        variant = Random.Range(1, 6);
        PlayerPrefs.SetInt("scenario", variant);
        SceneManager.LoadScene("helper");
    }
}
