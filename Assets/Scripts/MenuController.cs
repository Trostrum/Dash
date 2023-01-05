using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
	public GameObject MainButtonPanel,LevelButtonPanel;

	public void OpenLevelButton()
	{
		LevelButtonPanel.SetActive(true);
		MainButtonPanel.SetActive(false);
		
	}
	
	public void OpenMainButton()
	{
		MainButtonPanel.SetActive(true);
		LevelButtonPanel.SetActive(false);
		
	}
	
	//public void PlayGame()
	//{
	//	SceneManager.LoadScene();
	//}





}

