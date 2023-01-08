using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUIStorageValue : MonoBehaviour
{
	// Start is called before the first frame update
	private Text scoreText;
	private int scoreValue;
	
	public static ScoreUIStorageValue instance;
    void Start()
	{
		instance = this;
		scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
		scoreValue = 0;
		scoreText.text = scoreValue.ToString();
    }

    // Update is called once per frame
	public void AddScore(int value)
	{
		scoreValue+=value;
		scoreText.text = scoreValue.ToString();

	}
	public void RemoveScore(int value)
	{
		scoreValue-=value;
		scoreText.text = scoreValue.ToString();

	}
	public void ResetScore(int value)
	{
		scoreValue+=0;
		scoreText.text = scoreValue.ToString();

	}
}
