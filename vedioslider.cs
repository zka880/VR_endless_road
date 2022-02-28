using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vedioslider : MonoBehaviour
{


    public float vediospeed;
    public Text vb;


    void Start()
    {

    }

    void Update()
    {
        vediospeed = GetComponent<Slider>().value / 10;
        vb.GetComponent<Text>().text = vediospeed.ToString("F1");
    }
}