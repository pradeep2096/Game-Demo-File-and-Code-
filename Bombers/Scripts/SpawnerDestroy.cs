using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerDestroy : MonoBehaviour {
    public bool trigger;
    CircleCollider2D Cd;

	// Use this for initialization
	void Start () {
        Cd = GetComponent<CircleCollider2D>();
        
		
	}
	
	// Update is called once per frame
	void Update () {
        if(trigger)
        {
            Cd.isTrigger = true;
        }
        
		
	}
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "BlackLine") || (collision.gameObject.tag == "Platform") || (collision.gameObject.tag == "Player") || (collision.gameObject.tag == "bubble1"))
        {
            Destroy(this.gameObject);
        }
    }


}
