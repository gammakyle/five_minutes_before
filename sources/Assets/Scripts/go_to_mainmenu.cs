using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_to_mainmenu : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("main menu");

    }
}
