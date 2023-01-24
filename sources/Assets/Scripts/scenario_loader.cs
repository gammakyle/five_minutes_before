using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenario_loader: MonoBehaviour
{

    int scenario = 0;
    public GameObject scenario1;
    public GameObject scenario2;
    public GameObject scenario3;
    public GameObject scenario4;
    public GameObject scenario5;
    public GameObject finbutton;



    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("type_of_final", 0);

        scenario = PlayerPrefs.GetInt("scenario");

        Debug.Log(scenario.ToString());
        finbutton.SetActive(false);

        if (scenario == 1)
        {
            scenario2.SetActive(false);
            scenario3.SetActive(false);
            scenario4.SetActive(false);
            scenario5.SetActive(false);
        }
        if (scenario == 2)
        {
            scenario1.SetActive(false);
            scenario3.SetActive(false);
            scenario4.SetActive(false);
            scenario5.SetActive(false);
        }
        if (scenario == 3)
        {
            scenario1.SetActive(false);
            scenario2.SetActive(false);
            scenario4.SetActive(false);
            scenario5.SetActive(false);
        }
        if (scenario == 4)
        {
            scenario1.SetActive(false);
            scenario2.SetActive(false);
            scenario3.SetActive(false);
            scenario5.SetActive(false);
        }
        if (scenario == 5)
        {
            scenario1.SetActive(false);
            scenario2.SetActive(false);
            scenario3.SetActive(false);
            scenario4.SetActive(false);
        }

    }
}
