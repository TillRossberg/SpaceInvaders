using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MasterClass : MonoBehaviour
{
    public GUISkin style;
    public  int currentScore = 0;
    public int currentEnemies = 55;
    public int currentLives = 3;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(currentEnemies == 25) { EnemyBehaviour.movementSpeed = 1.5f; }
        else if (currentEnemies == 10) { EnemyBehaviour.movementSpeed = 2; }
        else if (currentEnemies == 5) { EnemyBehaviour.movementSpeed = 3; }
        else
        if (currentEnemies == 0)
        {
            Debug.Log("You win!");
            GetComponent<LevelLoader>().loadLevel(3);
        }
        if (currentLives <= 0)
        {
            Debug.Log("You lose!");
            GetComponent<LevelLoader>().loadLevel(4);
        }
    }

    private void OnGUI()
    {
        GUI.skin = style;
        GUI.Label(new Rect(20, 20, 1000, 50), "SCORE < " + currentScore.ToString() + " >");
        GUI.Label(new Rect(20, 700, 1000, 50), currentLives.ToString() );

    }
}
