using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealthpickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        playerchara player = other.GetComponent<playerchara>();
        if (player != null)
        {
            Destroy(this.gameObject);
            //   ReactiveTarget target = this.GetComponent<ReactiveTarget>();
            //   target.ReactToHit();
            if (player._health < 16)
            {
                player._health += 4;
            }
            if (player._health >= 16)
            {
                player._health = 20;
            }
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
