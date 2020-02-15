using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorBehaviour : MonoBehaviour {
     Rigidbody2D rb;
   // public float minx, maxx, miny, maxy;
    public float speed1, speed2;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        //gameObject.transform.position = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
        
	}

    // Update is called once per frame
    private void Update()
    {
         if (GameObject.Find("SceneManager").GetComponent<Scene1>().scene1)
         {
            speed1 = 1.5f;
            speed2 = 3f;
            Debug.Log("Its Scene 1");
        }
        if (GameObject.Find("SceneManager").GetComponent<Scene1>().scene2)
        {
            speed1 = 1.5f;
            speed2 = 6f;
            Debug.Log("Its Scene 2");
        }
        if (GameObject.Find("SceneManager").GetComponent<Scene1>().scene3)
        {
            speed1 = 2.2f;
            speed2 = 3.5f;
            Debug.Log("Its Scene 3");
        }

        rb.velocity = Vector2.down * (Random.Range(speed1, speed2));
    }
}
