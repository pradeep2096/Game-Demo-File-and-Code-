using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerDestroy2 : MonoBehaviour {
    public bool trigger2;
    CircleCollider2D Cd2;

    // Use this for initialization
    void Start () {
        Cd2 = GetComponent<CircleCollider2D>();

    }
	
	// Update is called once per frame
	void Update () {
        if (trigger2)
        {
            Cd2.isTrigger = true;
        }

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "WhiteLine") || (collision.gameObject.tag == "Platform") || (collision.gameObject.tag == "Player")||(collision.gameObject.tag=="bubble1"))
        {
            Destroy(this.gameObject);
        }
    }
}
