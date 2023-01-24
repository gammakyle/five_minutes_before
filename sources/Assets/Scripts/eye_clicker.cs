using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eye_clicker : MonoBehaviour
{
    private GameObject EventSystem;
    public string clicked_object;
    private Material Material_Lantern;
    private Material Material_Standart;
    public bool collided = false;


    void OnTriggerEnter2D(Collider2D other)
    {
        var Gobject = other.gameObject;
        if (Gobject.gameObject.tag == "Player_hand")
        {
            this.GetComponent<Renderer>().material = Material_Lantern;
            collided = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        this.GetComponent<Renderer>().material = Material_Standart;
        collided = false;
    }



    void Start()
    {
        EventSystem = GameObject.Find("EventSystem");
        Material_Lantern = EventSystem.GetComponent<Material_examples>().Lantern;
        Material_Standart = EventSystem.GetComponent<Material_examples>().Standart;
        this.GetComponent<Renderer>().material = Material_Standart;
    }
    /*
    void OnMouseEnter()
    {
        if(collided == true)
        {
            this.GetComponent<Renderer>().material = Material_Lantern;
        }
    }

    void OnMouseExit()
    {
        this.GetComponent<Renderer>().material = Material_Standart;
    }
    */
    void OnMouseDown()
    {
        if (collided == true)
        {
            clicked_object = this.name;
            EventSystem.GetComponent<story_talker>().nameobject_getter(clicked_object);
        }
        else
        {
            EventSystem.GetComponent<story_talker>().nameobject_getter("none");
        }

    }


}