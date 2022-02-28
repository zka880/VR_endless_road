using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchMaterial : MonoBehaviour
{
    public Texture t1;
    public Texture t2;
    public Texture t3;
    public Texture t4;
    public float i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 0)
        {
            GetComponent<Renderer>().material.mainTexture = t1;
        }
        if (i == 1)
        {
            GetComponent<Renderer>().material.mainTexture = t2;
        }
        if (i == 2)
        {
            GetComponent<Renderer>().material.mainTexture = t3;
        }
        if (i == 3)
        {
            GetComponent<Renderer>().material.mainTexture = t4;
        }
    }
}

