using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	// Start is called before the first frame update
	Rigidbody rb;
	Transform player;
	public float Acceleration;
	public float moveSpeed;
	public CanvasGroup GameEnd;
	public bool isEnd;
	
	public static PlayerController instance;
	
    void Start()
	{
		if(instance == null)
		{
			instance = this;
		}
	    rb = this.GetComponent<Rigidbody>();
	    player = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
	    moveZ();
	    keyboardInput();
	    
	    if(isEnd)
	    {
	    	fadeInCanvas();
	    	if(GameEnd.alpha == 1)
	    	{
	    		isEnd = false;
	    		this.enabled = false;
	    	}
	    }
    }
    
    
    
    
	void moveZ()
	{
		player.position = new Vector3(player.position.x, player.position.y, player.position.z+0.01f*Acceleration);
		//Acceleration+=0.0001f;
		
	}
	
	void keyboardInput()
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			player.position = new Vector3(player.position.x+Mathf.Abs(moveSpeed*0.001f), player.position.y, player.position.z);
			
		}
		else if(Input.GetKey(KeyCode.LeftArrow))
		{
			player.position = new Vector3(player.position.x+Mathf.Abs(moveSpeed*0.001f)*-1, player.position.y, player.position.z);
			
		}
	}
	
	
	void fadeInCanvas()
	{
		GameEnd.alpha += Time.deltaTime;
	}
	 //OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	
}
