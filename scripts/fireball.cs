using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {
    public float speed = 9.0f;
    public int damage = 2;
    public float timer;
	// Use this for initialization
	void OnTriggerEnter (Collider other) {
        Destroy(this.gameObject);
        playerchara player = other.GetComponent<playerchara>();
        if (player!= null)
        {
            player.Hurt(damage);
        }
	}
    
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (transform.position.y > 100 || timer > 4)
        {
            Destroy(this.gameObject);
        }

        transform.Translate(0, 0, speed * Time.deltaTime);
	}
}
