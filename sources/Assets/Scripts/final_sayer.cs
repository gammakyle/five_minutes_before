using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class final_sayer : MonoBehaviour
{
    public GameObject TextPanel1;
    public GameObject TextPanel2;

    void Start()
    {
        PlayerPrefs.SetInt("achivement_1", 1);


        if (PlayerPrefs.GetInt("type_of_final") == 1)
        {
            PlayerPrefs.SetInt("achivement_3", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "������ ����";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "������ ������� �� ���� ����� ���� ���� � ��������. ����� ����, ��� ��� ��������� �������� ������� ���, �� ����� ��������� ����. ��� ������, ��� �� ������ �������.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 2)
        {
            PlayerPrefs.SetInt("achivement_4", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "���� �����";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "����� �������� ��������� ���� ����� �������� ���������. ��������, ��� ���� �������� � ��� ����� ���������� ��������� � ����� ���� � ��� ����� - ����� ������ ����� �������� � ���� ����. �� ������ �������.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 3)
        {
            PlayerPrefs.SetInt("achivement_5", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "��� �����";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "����������� �� ����, ������ ����� ����� ���������. ����� �� ���������� �� ������ �������� ������ ������, �� ��� ���� ��� �������� �������. � �������, �� ������ �������.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 4)
        {
            PlayerPrefs.SetInt("achivement_6", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "���� ��������";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "�������� �� ����� ����� ����� �������� � �� �������, ���� ������ �������������, ����� ������������� ����������� �������. �����, ������� � ��������, ��������� - ��� ��� ����� ������� ��������� ����. �� �� ������ �������.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 5)
        {
            PlayerPrefs.SetInt("achivement_7", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "����� ���������";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "�������� ������ - �������� ������ � ����� ����������� ������. ���������� ����� ����� �� ������������� ����� ����� ������� �� ��������� � �������� ��������. �� ������ ��� ����������. ";
        }

        if (PlayerPrefs.GetInt("type_of_final") == 6)
        {
            PlayerPrefs.SetInt("achivement_2", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "����������";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "������������� ���� ������� �������� ����������. � ���������, ��� �� ������� ���������� ������������. ���� �������� ������ �������� ��� ��������� ��� �����, � ��������� � ������ ����� ������� ���� �������.";
        }


        if (PlayerPrefs.GetInt("type_of_final") == 9)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "������������ ������ �������";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "��� �� ������� ���������� ������������, �������� �� ������� �������. ������, ��� ���� �����? ����� ����� �������� ��������� ��, ��� ���� �������� � ������ �������?";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 10)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "���� � �����";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "�� ������ ������ ����, ������� ������ ��� �������� � ��������� ��� �����������. ���� �������� �������� �������, ����� �� ������������ �� ���������� �������.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 11)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "����� � ���";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "��������� - ���� ������ ���. ������� � ������ ���� �� �������� ��� �� ������ �� �����? � ���������, � ��� ���� �� ���� �������, ����� ��������� �� ����������� �� �������, ������ ��� �� ������� �� ������� �����.";
        }
    }
}
