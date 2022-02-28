using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionset : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    public GameObject handpos;
                 

	// Update is called once per frame
	void Update () {

        this.transform.position = new Vector3(handpos.transform.position.x, handpos.transform.position.y, handpos.transform.position.z);
	}
}
