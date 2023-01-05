using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
	// Start is called before the first frame update
    
	public GameObject fireBalls;
    void Update()
    {
    	if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
    	{
    		Debug.Log("Pressed Mouse Button 1");
    		
    		Instantiate(fireBalls,new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z+1),Quaternion.identity);
    		
    	}
    }
}
