using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
	// Start is called before the first frame update
    
	public GameObject fireBalls;
	private bool shouldFire;
	public float fireSpeed = 0.5f;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		StartCoroutine(waitFor());
	}
	void Update()
	{
		if(shouldFire)
		{
			if(Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
			{
				Debug.Log("Pressed Mouse Button 1");
				Instantiate(fireBalls,new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z+1),Quaternion.identity);
				StartCoroutine(waitFor());
			}
	    }
    	
	}
    
	IEnumerator waitFor()
	{
		shouldFire = false;
		yield return new WaitForSecondsRealtime(fireSpeed);
		shouldFire = true;
	}
    
	
	// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	
}
