using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basicslider : MonoBehaviour
{


    public float basicspeed;
    public Text bb;


    void Start()
    {

    }

    void Update()
    {
        basicspeed = GetComponent<Slider>().value / 10;
        bb.GetComponent<Text>().text = basicspeed.ToString("F1");
    }
}