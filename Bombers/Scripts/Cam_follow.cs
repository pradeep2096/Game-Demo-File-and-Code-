using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_follow : MonoBehaviour {
    public Transform player;
    public float cameradist;
    /*private void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameradist);
    }*/

    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
    public float smooth = .12f;
    public Transform target;
    Vector3 velocity = Vector3.zero;
    public bool YMaxEnable;
    public float YMax=0;

    public bool YMinEnable;
    public float YMin=0;

    public bool XMaxEnable;
    public float XMax=0;

    public bool XMinEnable;
    public float XMin=0;




    private void FixedUpdate()
    {
        Vector3 targetpos = target.position;
        if(YMaxEnable && YMinEnable)
        {
            targetpos.y = Mathf.Clamp(target.position.y, YMin, YMax);
        }
        else if(YMinEnable)
        {
            targetpos.y = Mathf.Clamp(target.position.y, 0, 0);
        }
        else if(YMaxEnable)
        {
            targetpos.y = Mathf.Clamp(target.position.y, 0, 0);
        }

        if(XMaxEnable && XMinEnable)
        {
            targetpos.x = Mathf.Clamp(target.position.x,XMin,XMax);
        }
        else if(XMinEnable)
        {
            targetpos.x = Mathf.Clamp(target.position.x, XMin, target.position.x);
        }
        else if(XMaxEnable)
        {
            targetpos.x = Mathf.Clamp(target.position.x, target.position.x, XMax);
        }


        targetpos.z = transform.position.z;
        transform.position = Vector3.SmoothDamp(transform.position, targetpos, ref velocity, smooth);
    }
}
