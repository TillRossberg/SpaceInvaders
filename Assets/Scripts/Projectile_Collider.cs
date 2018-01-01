using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Collider : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject levelManager = GameObject.Find("LevelManager");
            levelManager.GetComponent<MasterClass>().currentScore += 250;
            levelManager.GetComponent<MasterClass>().currentEnemies -= 1;
            levelManager.GetComponent<Audio_Manager>().playInvaderDied();
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Boss")
        {
            GameObject levelManager = GameObject.Find("LevelManager");
            levelManager.GetComponent<MasterClass>().currentScore += 1000;            
            levelManager.GetComponent<Audio_Manager>().playInvaderDied();
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.name == "Block")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.name != "PlayerShip")
        {
            Destroy(this.gameObject);
        }
    }
}
