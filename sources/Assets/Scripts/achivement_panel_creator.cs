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
            TextMeshProLable.text = "\"Сыщик\" - Вы прошли игру 1 раз";
        }
        if (PlayerPrefs.GetInt("achivement_2") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Не элементарно\" - Вы взяли не того";
        }
        if (PlayerPrefs.GetInt("achivement_3") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel3.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Мистер Смит\" - Вы нашли убийцу";
        }
        if (PlayerPrefs.GetInt("achivement_4") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel4.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Мерри Клаус\" - Вы нашли убийцу";
        }
        if (PlayerPrefs.GetInt("achivement_5") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel5.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Сэм Фишер\" - Вы нашли убийцу";
        }
        if (PlayerPrefs.GetInt("achivement_6") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel6.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Роуз Андерсон\" - Вы нашли убийцу";
        }
        if (PlayerPrefs.GetInt("achivement_7") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel7.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Барни Блеквотер\" - Вы нашли убийцу";
        }
        if (PlayerPrefs.GetInt("achivement_8") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel8.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Мяу!\" - Вы спасли котенка";
        }
        if (PlayerPrefs.GetInt("achivement_9") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel9.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Часики то тикают...\" - кончилось время";
        }
        if (PlayerPrefs.GetInt("achivement_10") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel10.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Тихий час\" - Вы решили уйти в закат";
        }
        if (PlayerPrefs.GetInt("achivement_11") == 1)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel11.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Вам крышка!\" - Вы провалились в люк";
        }
        if ((PlayerPrefs.GetInt("achivement_1") == 1)&& (PlayerPrefs.GetInt("achivement_2") == 1) && (PlayerPrefs.GetInt("achivement_3") == 1) && (PlayerPrefs.GetInt("achivement_4") == 1) && (PlayerPrefs.GetInt("achivement_5") == 1) && (PlayerPrefs.GetInt("achivement_6") == 1) && (PlayerPrefs.GetInt("achivement_7") == 1) && (PlayerPrefs.GetInt("achivement_8") == 1) && (PlayerPrefs.GetInt("achivement_9") == 1) && (PlayerPrefs.GetInt("achivement_10") == 1) && (PlayerPrefs.GetInt("achivement_11") == 1))
        {
            TextMeshProUGUI TextMeshProLable = TextPanel12.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "\"Спасибо за игру!\" - Final";
        }

    }
}
