using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_saver : MonoBehaviour
{
    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
