using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject EventSystem;
    public float speed = 5f;
    public Rigidbody2D player_rigidbody;
    public GameObject legR;
    public GameObject legL;
    public Camera cam;

    bool LEVOY = false;

    public Vector2 movement;
    public Vector2 mousePos;

    Vector3 endLocalPosition_legR = new Vector3(-0.1990013f, -0.1f, 0.0f);
    Vector3 startLocalPosition_legR = new Vector3(-0.1990013f, 0.1f, 0.0f);
    Vector3 endLocalPosition_legL = new Vector3(0.237999f, -0.1f, 0.0f);
    Vector3 startLocalPosition_legL = new Vector3(0.237999f, 0.1f, 0.0f);

    void Start()
    {
        EventSystem = GameObject.Find("EventSystem");
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        cam.transform.eulerAngles = new Vector3(0, 0, 0);
        if((movement.x != 0) | (movement.y != 0))
        {
            if(legR.transform.localPosition == startLocalPosition_legR)
            {
                LEVOY = false;
            }
            if (legR.transform.localPosition == endLocalPosition_legR)
            {
                LEVOY = true;
            }
            if(LEVOY==false)
            {
                legR.transform.localPosition = Vector3.Lerp(legR.transform.localPosition, endLocalPosition_legR, Time.deltaTime * 20f);
                legL.transform.localPosition = Vector3.Lerp(legL.transform.localPosition, startLocalPosition_legL, Time.deltaTime * 20f);
            }
            else
            {
                legR.transform.localPosition = Vector3.Lerp(legR.transform.localPosition, startLocalPosition_legR, Time.deltaTime * 20f);
                legL.transform.localPosition = Vector3.Lerp(legL.transform.localPosition, endLocalPosition_legL, Time.deltaTime * 20f);
            }

            EventSystem.GetComponent<story_talker>().nameobject_getter("send_zero");

        }
        else
        {
            legR.transform.localPosition = Vector3.Lerp(legR.transform.localPosition, startLocalPosition_legR, Time.deltaTime * 20f);
            legL.transform.localPosition = Vector3.Lerp(legL.transform.localPosition, startLocalPosition_legL, Time.deltaTime * 20f);
        }

    }

    void FixedUpdate()
    {
        player_rigidbody.MovePosition(player_rigidbody.position + movement * speed * Time.fixedDeltaTime);
        
    }
}
