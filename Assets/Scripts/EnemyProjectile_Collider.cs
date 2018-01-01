using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile_Collider : MonoBehaviour
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
        if (other.gameObject.name == "Block")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
        else
        if (other.gameObject.name == "PlayerShip")
        {
            Destroy(this.gameObject);
            //Destroy(other.gameObject);
            GameObject.Find("LevelManager").GetComponent<Audio_Manager>().playExplosion();
            GameObject.Find("LevelManager").GetComponent<MasterClass>().currentLives -= 1;
        }
        else
        if (other.gameObject.name == "downBorder")
        {
            Destroy(this.gameObject);
        }
    }
}
