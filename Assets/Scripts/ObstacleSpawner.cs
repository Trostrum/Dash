using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class ObstacleSpawner : MonoBehaviour
{
	
	public GameObject red;
	public GameObject blue;
	[Range(1,10)]
	public int level;
	[SerializeField]
	public float startOffSet;
	[SerializeField]
	public float incrementalDistanceZ,incrementalDistanceX;
	[SerializeField]
	private float distance;
	[SerializeField]
	private float density;
	private Vector3 spawnLocation;
	[SerializeReference]
	private float spawnSpeed;
	[SerializeReference]
	private float spawnHeight;
    
    void Start()
	{
		StartCoroutine(spawnObstacle());
		
    }
	
	IEnumerator spawnObstacle()
	{
		spawnLocation = new Vector3(0,0.2f,startOffSet);
		for(int i = 0;i<distance;i++)
		{
			startOffSet +=incrementalDistanceZ;
			spawnLocation = new Vector3(0,2f,startOffSet);
			float xlocation = -1.3f;
			for(int j = 0;j<density;j++)
			{
				xlocation+=incrementalDistanceX;
				if(xlocation>1.3f)
				{
					break;
				}
				spawnLocation = new Vector3(xlocation,spawnHeight,startOffSet);
				int rnd = Random.Range(1,level);
				if(rnd <= 1)
				{
					Instantiate(red,spawnLocation,Quaternion.identity,this.transform);		
				}
				else if(rnd > 1)
				{	
					Instantiate(blue,spawnLocation,Quaternion.identity,this.transform);		
				}
				yield return new WaitForSeconds(spawnSpeed);
			}
		}
		StartCoroutine(spawnObstacle());
		
	}
    // Update is called once per frame
    
}
