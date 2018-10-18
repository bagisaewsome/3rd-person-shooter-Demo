using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenDevice : MonoBehaviour {
    [SerializeField]
    private Vector3 dPos;
    private bool _open;
    private  float startTime ;
    public float timer;
	// Use this for initialization
	void Start () {
        startTime = Time.deltaTime;
        _open = true;
	}
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 15 && _open != true)
        {
            Vector3 pos = transform.position + dPos;
            transform.position = Vector3.Lerp(transform.position, pos, (Time.time - startTime) / 1.0f);
            //  transform.position = pos;
            _open = !_open;
            timer = 0.0f;
        }
    }

    // Update is called once per frame
    void Operate () {

        if (_open == true)
        {
            Vector3 pos = transform.position - dPos;
            transform.position = Vector3.Lerp(transform.position, pos, (Time.time - startTime) / 1.0f);
            //   transform.position = poss
            _open = !_open;
        }

    }
}
