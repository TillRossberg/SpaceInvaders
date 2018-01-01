using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 movement = Vector3.zero;
    private CharacterController controller;
    public float speed = 0.5f;
    public float bulletSpeed = 50;
    GameObject levelManager;
    public GameObject bullet;


    // Use this for initialization
    void Start ()
    {
        levelManager = GameObject.Find("LevelManager");

        controller = GetComponent<CharacterController>();	
	}
	
	// Update is called once per frame

	void Update ()
    {        
        if(Input.GetAxis("Horizontal") != 0)
        {
            movement = new Vector3(Input.GetAxis("Horizontal"),0,0);        
            movement *= speed;
            controller.Move(movement * Time.deltaTime);
        }

        if(Input.GetKeyUp("space"))
        {
            levelManager.GetComponent<Audio_Manager>().playFireSound();
            GameObject spawnBullet = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
            spawnBullet.GetComponent<Rigidbody>().AddForce(Vector3.up * bulletSpeed);
        }
    }
}
