using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_to_changer : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("change scene");

    }
}
