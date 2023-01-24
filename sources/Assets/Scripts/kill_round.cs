using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill_round : MonoBehaviour
{
    int randkill = 0;

    void OnTriggerStay2D(Collider2D other)
    {
        var Gobject = other.gameObject;
        if (Gobject.gameObject.tag == "Player_hand")
        {
            randkill = Random.Range(1, 250);
            if(randkill == 33)
            {
                PlayerPrefs.SetInt("achivement_11", 1);
                PlayerPrefs.SetInt("type_of_final", 11);
                SceneManager.LoadScene("final scene");
            }
        }
    }
}
