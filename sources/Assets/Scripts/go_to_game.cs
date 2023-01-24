using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_to_game : MonoBehaviour
{

    void OnMouseDown()
    {
        SceneManager.LoadScene("main scene");
    }
}
