using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class raiseplatform : MonoBehaviour {
    [SerializeField]
    public Transform canvas;
    // Use this for initialization
    [SerializeField]
    public Transform Player;
    // Use this for initialization
    public void Start()
    {
        Player.GetComponent<sceneloader>().enabled = false;
    }
    public void move () {
        this.transform.Translate(0, 1, 0);
	}
    void OnTriggerEnter(Collider other)
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
        }
        Player.GetComponent<sceneloader>().enabled = true;
    }
    // Update is called once per frame
    void Update () {

    }
}
