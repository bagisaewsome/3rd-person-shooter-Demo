using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wallopen : MonoBehaviour {
    //    [SerializeField]
    //    public GameObject wall;
    [SerializeField]
    public Text objective;
    GameObject target;
    // Use this for initialization
    void Start () {
        target = GameObject.FindWithTag("wall");
    }
	public void Operate()
    {
        objective.text = "continue through the valley";
    GetComponent<Renderer>().material.color = new Color (1f, 0f ,0f);
        //  Destroy(this.gameObject);
        Destroy(target);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
