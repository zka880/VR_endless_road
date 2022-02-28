using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mslider : MonoBehaviour
{
    public switchMaterial num;
 

    // Update is called once per frame
    void Update()
    {
        num.GetComponent<switchMaterial>().i = GetComponent<Slider>().value;
    }
}
