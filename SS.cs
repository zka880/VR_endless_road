using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SS : MonoBehaviour
{


    public playControl movespeed;
    public bairitsu speedtex;
    public TolDis tolaldistance;
    //public vedioslider vediospeed;
    //public basicslider basicspeed;
    public float td;
    public float bs;



    void Start()
    {

    }

    void Update()
    {
        //bs = basicspeed.GetComponent <basicslider>().basicspeed;
        //vs = vediospeed.GetComponent<vedioslider>().vediospeed;
        bs = 1 / 3.6f;
        movespeed.GetComponent<playControl>().ms = GetComponent<Slider>().value / 10 * bs;
        speedtex.GetComponent<bairitsu>().bai = GetComponent<Slider>().value / 10;
        tolaldistance.GetComponent<TolDis>().td = movespeed.GetComponent<playControl>().TotalDis;
    }
}
