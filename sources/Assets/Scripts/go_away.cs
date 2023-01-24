using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_away : MonoBehaviour
{

    void OnTriggerStay2D(Collider2D other)
    {
        var Gobject = other.gameObject;
        if (Gobject.gameObject.tag == "Player_hand")
        {
                PlayerPrefs.SetInt("achivement_10", 1);
                PlayerPrefs.SetInt("type_of_final", 10);
                SceneManager.LoadScene("final scene");
        }
    }
}
