using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System;

public class SpeedInput : MonoBehaviour {

    // Use this for initialization
    public float speed;

    void Start () {
       GetComponent<InputField>().text = "3.6";  //InputFieldにテキストが設定される
    }

    // Update is called once per frame

	public void SpeedCh () {
        try
        {
            GameObject.Find("BSlider").GetComponent<Slider>().value = float.Parse(GetComponent<InputField>().text)*10;
        }
        catch (FormatException e)
        {
            Debug.Log(e.Message);
        }
    }
    private void Update()
    {
        

    }


}
