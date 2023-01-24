using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiochecker : MonoBehaviour
{

    public GameObject aud_box;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("audio_screamer(Clone)") == null)
        {
            Vector3 pos = new Vector3(0, 0, 0);
            Instantiate(aud_box, pos, Quaternion.identity);
        }
    }
}
