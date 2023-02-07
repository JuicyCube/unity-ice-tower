using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public bool platformsMoveDown;

	public Animator panelGameOverAnim;
	//public Text gameScore;
	//public Text menuScore;
	// Start is called before the first frame update
	void Start()
    {
        platformsMoveDown = false;
    }

	public void GameOver()
	{
		GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
		panelGameOverAnim.SetTrigger("Open");
		//menuScore.text = gameScore.text;
		//gameScore.gameObject.SetActive(false);
	}

	public void PlayAgain()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}
}
