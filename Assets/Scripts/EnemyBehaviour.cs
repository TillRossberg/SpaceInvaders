using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    static bool go_left = false;
    static bool go_right = true;
    

    public static float movementSpeed = 1;
    private int timer = 300;
    public GameObject enemyProjectile;
    private int bulletSpeed = 300;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Movement
		if(go_left)
        {
            Vector3 movement = new Vector3(this.transform.position.x - (movementSpeed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
            transform.position = movement;      
        }
        
        if(go_right)
        {
            Vector3 movement = new Vector3(this.transform.position.x + (movementSpeed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
            transform.position = movement;
        }

       
        //Attack
        timer -= 1;
        if(timer < 2)
        {
            int randomNumber = Random.Range(0, 20);
            if(randomNumber == 2)
            {
                GameObject bullet = Instantiate(enemyProjectile, transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().AddForce(Vector3.down * bulletSpeed);
            }
            timer = 300;
        }

	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "leftBorder")
        {
            go_left = false;
            go_right = true;
            moveDown();
        }
        
        if (other.gameObject.name == "rightBorder")
        {
            go_left = true;
            go_right = false;
            moveDown();
        }

        if (other.gameObject.name == "PlayerShip")
        {
            Destroy(this.gameObject);
            GameObject.Find("LevelManager").GetComponent<MasterClass>().currentLives -= 1;
        }

        if (other.gameObject.name == "Block")
        {
            Destroy(other.gameObject);
        }
    }

    private void moveDown()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach(GameObject enemy in enemies)
        {
            Vector3 movement = new Vector3(enemy.transform.position.x , enemy.transform.position.y - 0.3f, enemy.transform.position.z);
            enemy.transform.position = movement;
        }
    }
}
