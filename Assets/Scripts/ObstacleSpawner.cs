﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
	public GameObject obstacle;
	
    // Start is called before the first frame update
    void Start()
    {
	    InstantiateObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	void InstantiateObstacle()
	{
		GameObject newObstacle = Instantiate(obstacle);
		newObstacle.transform.position = new Vector2(transform.position.x,transform.position.y);
			
	}
}
