using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if((collision.gameObject.tag=="Player")&&(gamemanagerr.health<100))
        {
            gamemanagerr.health += 5;
        }
        if(collision.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
    }
}
