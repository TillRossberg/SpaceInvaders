using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void loadLevel(int number)
    {
        switch(number)
        {
            //Main menu
            case 0:
                SceneManager.LoadScene("MainMenu");
                break;

            case 1:
                SceneManager.LoadScene("Scene01");
                break;

            case 2:
                SceneManager.LoadScene("HighScores");
                break;

            case 3:
                SceneManager.LoadScene("WinScreen");
                break;

            case 4:
                SceneManager.LoadScene("LoseScreen");
                break;

            default:
                Debug.Log("No such level found!");
                break;
        }
    }
}
