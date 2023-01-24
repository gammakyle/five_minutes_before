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
            TextMeshProLable.text = "Мистер Смит";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "Бывший военный не смог унять свою тягу к алкоголю. После того, как ему запретили посещать местный бар, он решил отомстить Роуз. Как хорошо, что Вы успели вовремя.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 2)
        {
            PlayerPrefs.SetInt("achivement_4", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "Мери Клаус";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "Милая старушка оказалась куда более страшным человеком. Опасаясь, что Роуз заботясь о ней решит переписать имущество и сдать Мери в дом опеки - Клаус решила взять ситуацию в свои руки. Вы успели вовремя.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 3)
        {
            PlayerPrefs.SetInt("achivement_5", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "Сэм Фишер";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "Озлобленный на Роуз, старый рыбак решил отомстить. Пусть он действовал не всегда согласно нормам вылова, но это была его семейная фабрика. К счастью, Вы успели вовремя.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 4)
        {
            PlayerPrefs.SetInt("achivement_6", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "Роуз Андерсон";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "Уставшая от жизни среди косых взглядов в ее сторону, Роуз хорошо подготовилась, чтобы инсценировать собственную пропажу. Парик, записка с угрозами, документы - все это могло создать нерешимое дело. Но Вы успели вовремя.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 5)
        {
            PlayerPrefs.SetInt("achivement_7", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "Барни Блеквотер";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "Разбитое сердце - страшное оружие в руках неокрепшего разума. Потерявший смысл жизни от неразделенной любви Барни решился на отчаянный и безумный поступок. Вы успели его остановить. ";
        }

        if (PlayerPrefs.GetInt("type_of_final") == 6)
        {
            PlayerPrefs.SetInt("achivement_2", 1);
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "Невиновный";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "Подозреваемый Вами человек оказался невиновным. К сожалению, Вам не удалось остановить преступление. Роуз Андерсон теперь числится как пропавшая без вести, а остальные и дальше будут хранить свои секреты.";
        }


        if (PlayerPrefs.GetInt("type_of_final") == 9)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "Преступление против времени";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "Вам не удалось остановить преступление, попросту не хватило времени. Однако, что есть время? Какой смысл пытаться исправить то, что лишь песчинка в рамках истории?";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 10)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "Ушли в закат";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "Вы просто решили уйти, оставив позади все проблемы и тяготящие Вас переживания. Ваше создание медленно угасает, вслед за скрывающимся за горизонтом Солнцем.";
        }
        if (PlayerPrefs.GetInt("type_of_final") == 11)
        {
            TextMeshProUGUI TextMeshProLable = TextPanel1.GetComponent<TextMeshProUGUI>();
            TextMeshProLable.text = "Упали в люк";
            TextMeshProUGUI TextMeshProLable2 = TextPanel2.GetComponent<TextMeshProUGUI>();
            TextMeshProLable2.text = "Нелепость - Ваше второе имя. Неужели в детсве мама не говорила Вам не ходить по люкам? К сожалению, у Вас даже не было времени, чтобы вспомнить ее наставления из детства, ржавый люк не оставил ни единого шанса.";
        }
    }
}
