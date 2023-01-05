using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIf : MonoBehaviour
{
    // Start is called before the first frame update
	// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	
	// OnTriggerEnter is called when the Collider other enters the trigger.
	public Transform player;
	
	// Awake is called when the script instance is being loaded.
	protected void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called every frame, if the MonoBehaviour is enabled.
	
	protected void LateUpdate()
	{
		if(this.transform.position.z<player.transform.position.z-2)
		{
			Destroy(this.gameObject);
		}
	}
	protected void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Fire"))
		{
			Destroy(this.gameObject);
		}
		if(this.gameObject.CompareTag("Blue") && other.gameObject.CompareTag("Player"))
		{
			Destroy(this.gameObject);
		}
		if(this.gameObject.CompareTag("Red") && other.gameObject.CompareTag("Player"))
		{
			PlayerController.instance.isEnd = true;
		}
	}
}
