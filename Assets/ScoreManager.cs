using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	// Start is called before the first frame update
	private Text score;
	private int scoreInt = 0;
  

    // Update is called once per frame

	// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	// OnTriggerEnter is called when the Collider other enters the trigger.
	protected void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Red"))
		{
			ScoreUIStorageValue.instance.AddScore(1);
		}
	}
}
