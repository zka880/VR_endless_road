using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bairitsu : MonoBehaviour {
	public float bai;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = bai.ToString ("F1");
	}
}
