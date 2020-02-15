using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    public Color[] ColorRange;
    SpriteRenderer sr;
    float starttime;
    float speed=1.3f;
    public Color color1;
    public Color color2;
 
    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
        //InvokeRepeating("colorchange", 0.1f, 1f);
        //int num = Random.Range(0, ColorRange.Length);
        starttime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
        float t =( Mathf.Sin(Time.time - starttime) * speed);
        sr.color = Color.Lerp(color1,color2, t);
        
    }
    void colorchange()
    {
        color1 = Color.HSVToRGB(Random.Range(0, 180), 100, 100);
        color2 = Color.HSVToRGB(Random.Range(180, 360), 100, 100);
    }
    /*void colorrange()
    {
        int num = Random.Range(0, ColorRange.Length);
        sr.color = ColorRange[num];
    }*/
}
