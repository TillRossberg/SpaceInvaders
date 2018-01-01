using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Boss : MonoBehaviour {
    public float bossSpeed = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(this.transform.position.x - bossSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
	}
}
