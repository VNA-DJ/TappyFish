using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
	int angle;
	int maxAngle = 20;
	int minAngle = -20;
	Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
	    rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetMouseButtonDown(0))
	    {
	    	rb2d.velocity = new Vector2(rb2d.velocity.x, 9f);
	    }
	    
	    transform.position = new Vector2(transform.position.x,Mathf.Clamp(transform.position.y,-10, 8));
    
	    if(rb2d.velocity.y > 0)
	    {
	    	if (angle <= maxAngle)
	    	{
	    		angle = angle + 4;
	    	}
	    }
	    
	    if(rb2d.velocity.y < -2.5f)
	    {
	    	if (angle > minAngle)
	    	{
	    		angle = angle -2;
	    	}
	    }
	    transform.rotation = Quaternion.Euler(0,0,angle);
    }
}
