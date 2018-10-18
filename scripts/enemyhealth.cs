using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour {
    public float health;
    public float maxhealth;
    float precentage;
    [SerializeField]
    gunfromcamera stat;
    public GameObject healthbar;
   // public bool gotton = false;
    // Use this for initialization
    private void Start()
    {
        health = maxhealth;
        gunfromcamera stat = GetComponent<gunfromcamera>();
    }
    public void hitlong()
    {
   //     if (gotton != true)
   //     {
            
     //   }
        health -= 1;
        sethealthbar();
        Debug.Log("hit");
    }
    public void hitShort()
    {
        health -= 2;
        sethealthbar();
        Debug.Log("hit");
    }

    // Update is called once per frame
    
	public void sethealthbar()
    {
        precentage = health / maxhealth;
        healthbar.transform.localScale = new Vector3(precentage, healthbar.transform.localScale.y , healthbar.transform.localScale.z );
    }
	// Update is called once per frame
	void Update () {
	    if (health <= 0)
        {
            Destroy(this.gameObject);
            gunfromcamera stat = GetComponent<gunfromcamera>();
            stat.updated = false;
        }	

	}
}
