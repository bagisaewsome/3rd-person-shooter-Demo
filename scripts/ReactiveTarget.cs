using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour {
    [SerializeField]
    public gunfromcamera list;

    // Use this for initialization
    public void ReactToHitL() {
        enemyhealth hit = GetComponent<enemyhealth>();
           hit.hitlong();
       // Destroy(this.gameObject);
	}
    public void ReactToHitS()
    {
        enemyhealth hit = GetComponent<enemyhealth>();
        hit.hitShort();
       //  Destroy(this.gameObject);
    }
    // Update is called once per frame
}
