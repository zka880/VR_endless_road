using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maxhight : MonoBehaviour
{
    
    private float maxY = 0f;  //最大Y座標
    private float DisY = 0f;  //Yの差
    private Vector3 onetimepos;
    public GameObject m_camera;
    public GameObject m_player;
    //public bool ismax = false;

        
    public void Ymax()
    {
        onetimepos = m_camera.transform.position;
        maxY = onetimepos.y;
    }

    public void Setstand()
    {
        onetimepos = m_camera.transform.position;
        DisY = maxY - onetimepos.y;
        m_player.transform.position += new Vector3(0, DisY, 0);
    }
}
