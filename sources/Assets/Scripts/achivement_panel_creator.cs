using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class achivement_panel_creator : MonoBehaviour
{

    public GameObject TextPanel1;
    public GameObject TextPanel2;
    public GameObject TextPanel3;
    public GameObject TextPanel4;
    public GameObject TextPanel5;
    public GameObject TextPanel6;
    public GameObject TextPanel7;
    public GameObject TextPanel8;
    public GameObject TextPanel9;
    public GameObject TextPanel10;
    public GameObject TextPanel11;
    public GameObject TextPanel12;


    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("achivement_1") ==1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"�����\" - �� ������ ���� 1 ���";
        }
        if (PlayerPrefs.GetInt("achivement_2") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"�� �����������\" - �� ����� �� ����";
        }
        if (PlayerPrefs.GetInt("achivement_3") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel3.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"������ ����\" - �� ����� ������";
        }
        if (PlayerPrefs.GetInt("achivement_4") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel4.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"����� �����\" - �� ����� ������";
        }
        if (PlayerPrefs.GetInt("achivement_5") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel5.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"��� �����\" - �� ����� ������";
        }
        if (PlayerPrefs.GetInt("achivement_6") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel6.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"���� ��������\" - �� ����� ������";
        }
        if (PlayerPrefs.GetInt("achivement_7") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel7.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"����� ���������\" - �� ����� ������";
        }
        if (PlayerPrefs.GetInt("achivement_8") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel8.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"���!\" - �� ������ �������";
        }
        if (PlayerPrefs.GetInt("achivement_9") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel9.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"������ �� ������...\" - ��������� �����";
        }
        if (PlayerPrefs.GetInt("achivement_10") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel10.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"����� ���\" - �� ������ ���� � �����";
        }
        if (PlayerPrefs.GetInt("achivement_11") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel11.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"��� ������!\" - �� ����������� � ���";
        }
        if ((PlayerPrefs.GetInt("achivement_1") == 1)&& (PlayerPrefs.GetInt("achivement_2") == 1) && (PlayerPrefs.GetInt("achivement_3") == 1) && (PlayerPrefs.GetInt("achivement_4") == 1) && (PlayerPrefs.GetInt("achivement_5") == 1) && (PlayerPrefs.GetInt("achivement_6") == 1) && (PlayerPrefs.GetInt("achivement_7") == 1) && (PlayerPrefs.GetInt("achivement_8") == 1) && (PlayerPrefs.GetInt("achivement_9") == 1) && (PlayerPrefs.GetInt("achivement_10") == 1) && (PlayerPrefs.GetInt("achivement_11") == 1))
        {
            TextMeshProUGUI TextMeshProLable = TextPanel12.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"������� �� ����!\" - Final";
        }

    }
}
