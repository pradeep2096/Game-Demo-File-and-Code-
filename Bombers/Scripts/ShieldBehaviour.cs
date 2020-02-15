using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaviour : MonoBehaviour {
    public float speed;

	// Use this for initialization
	void Start () {
        gameObject.transform.Rotate(new Vector3(0, 0, 1) * speed);


    }
	
	// Update is called once per frame
	void Update () {
        
		
	}
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(9f);
        Destroy(this.gameObject);
        

    }
}
