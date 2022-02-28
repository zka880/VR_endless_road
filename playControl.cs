using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playControl : MonoBehaviour
{

    public float ms;
    public float TotalDis;
    public AudioSource AS;
    public float timervalue = 10;
    float timer = 0;
    float pretimer = 0;
    float tt = 10;
    private bool start;
    private bool timerr;
    private bool timend = false;
    private bool timestart = false;
    public  GameObject VRUI;
    public GameObject vasvalue;
    public GameObject PCUIstart;
    public GameObject eventsystem;
    public GameObject timeinput;


    void Start()
    {
        VRUI.SetActive(false);
        //GameObject.Find("VivePointers").SetActive(false);
        PCUIstart.GetComponent<Button>().interactable = false;
        eventsystem.GetComponent<VRinputModule>().enabled = false;
        timeinput.GetComponent<InputField>().text = "2";
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            movestart();
        }

        if (start)
        {
            this.transform.position += new Vector3(0, 0, ms * Time.deltaTime);
            TotalDis += ms * Time.deltaTime;
        }

        if (timerr)
        {
            timer += Time.deltaTime;
            if (timer >= timervalue)
            {
                start = false;
                timerr = false;
                timer = 0;
                vasvalue.GetComponent<Slider>().value = 0f;
                eventsystem.GetComponent<VRinputModule>().enabled = true;
                eventsystem.GetComponent<UnityEngine.EventSystems.StandaloneInputModule>().enabled = false;
                PCUIstart.GetComponent<Button>().interactable = false;
                timend = true;
                //GameObject.Find("VivePointers").SetActive(true);
            }
        }

        if (timend)
        {
            pretimer += Time.deltaTime;
            if (pretimer >= tt)
            {
                VRUI.SetActive(true);
                timend = false;
                pretimer = 0;
            }
        }

        if(timestart)
        {
            pretimer += Time.deltaTime;
            if (pretimer >= tt)
            {
                AS.Play();
                timerr = true;
                start = true;
                GetComponent<Csv>().saves = true;
                pretimer = 0;
                timestart = false;
                //Debug.Log("ButtonClicked");
                //yield return new WaitForSeconds (1);	
                //timer = m_timer ;
                //if (m_timer - timer >= 1) {
                //}
            }
        }
    }

    public void movestart()
    {
        timestart = true;
    }

    public void Timecontrol()
    {
        timervalue = float.Parse(timeinput.GetComponent<InputField>().text);
    }
}
