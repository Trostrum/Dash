using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addVelocity : MonoBehaviour
{
	// Start is called before the first frame update
	
	public float force;
    
    // Update is called once per frame
    void Update()
	{
		this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z+force);
        
    }
}
