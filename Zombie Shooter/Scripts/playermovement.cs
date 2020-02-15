using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
	Vector3 rotation = new Vector3(0, 0, 0);
	public float speed = 3;
    float rotx, roty;
    public Joystick joy;
    public bool MouseInput, Joystick;
   
	// Start is called before the first frame update
	void Start()
    {
        
    }
	

	void Update()
	{
        if(MouseInput)
        {
            MouseMOV();
            print("Use mouse to rotate around");
        }
        if(Joystick)
        {
            TouchMov();
            print("Use joystick or touch to rotate around");
        }
        
	}
    void MouseMOV()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x -= Input.GetAxis("Mouse Y");
        transform.eulerAngles = (Vector3)rotation * speed;
    }
    void TouchMov()
    {
        roty += joy.Horizontal;
        rotx -= joy.Vertical;
        transform.eulerAngles = new Vector3(rotx, roty, 0) * speed;
        
    }
}

