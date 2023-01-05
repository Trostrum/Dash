using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
	// Start is called before the first frame update
	public float time;
    void Start()
    {
	    Invoke("DestroyMe",time);
    }

    // Update is called once per frame
	void DestroyMe()
	{
		Destroy(this.gameObject);
	}
}
