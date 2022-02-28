using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.UI;

public class VRUIcontrol : MonoBehaviour
{
    public GameObject vasvalue;
    public   float vas;
    public  float sence;
    //public float [,] n = new float [10,2];
    public string[] n;
    public GameObject mc;
    public int csvtrigger = 0;
    public GameObject VRUI;
    public GameObject eventsystem;
    public GameObject PCUIstart;
    public GameObject num;


    public void OnButtonClick()
    {
        sence = mc.GetComponent<switchMaterial>().i;
        vas = vasvalue.GetComponent<Slider>().value;
        //string[] n = { sence.ToString(), vas.ToString() };
        //n[ii, 1] = sence;
        //n[ii, 2] = vas;
        Debug.Log("ButtonClicked");
        csvtrigger = 1;
        //GameObject.Find("VivePointers").SetActive(false);
        eventsystem.GetComponent<UnityEngine.EventSystems.StandaloneInputModule>().enabled = true;
        eventsystem.GetComponent<VRinputModule>().enabled = false;
        PCUIstart.GetComponent<Button>().interactable = true;
        VRUI.SetActive(false);

        if (mc.GetComponent<switchMaterial>().i == 3)
        {
            num.GetComponent<Slider>().value = 0;
        }
        else
        {
            num.GetComponent<Slider>().value++;
        }
    }
}
