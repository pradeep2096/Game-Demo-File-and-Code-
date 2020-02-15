using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cammov : MonoBehaviour {
    public Transform target;
    public Vector3 offset;
    public int speed;

	// Use this for initialization
	void Start () {
        
        

    }

    // Update is called once per frame
    void Update () {
        Vector3 newpos = (target.position + offset)*speed;
        newpos.z = transform.position.z;
        newpos.y = transform.position.y;
        transform.position = newpos;
        if (GameObject.Find("SceneManager").GetComponent<Scene1>().scene3)
        {
            if (transform.position.x > 194.6f)
            {
                gameObject.transform.position = new Vector3(194.6f, 0, -10);
            }
        }
        if ((GameObject.Find("SceneManager").GetComponent<Scene1>().scene1) || (GameObject.Find("SceneManager").GetComponent<Scene1>().scene2))
        {
            if (transform.position.x > 124.5f)
            {
                gameObject.transform.position = new Vector3(124.65f, 0, -10);
            }
        }
    
    }
}
