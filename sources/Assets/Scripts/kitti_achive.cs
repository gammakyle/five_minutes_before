using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kitti_achive : MonoBehaviour
{
    void OnMouseDown()
    {
        PlayerPrefs.SetInt("achivement_8", 1);
    }
}
