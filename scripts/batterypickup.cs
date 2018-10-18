using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batterypickup : MonoBehaviour {
    //  [SerializeField]
    // gunfromcamera playerg;
    public int ammmo;
	// Use this for initialization
	void Start () {
		//int ammmo = playerchara.ammo
	}
    void OnTriggerEnter(Collider other)
    {          playerchara player = other.GetComponent<playerchara>();
        player.reload();
        Destroy(this.gameObject);

            
    //    }
    }
        // Update is called once per frame
        void Update () {
		
	}
}
