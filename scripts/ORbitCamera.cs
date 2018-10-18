using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORbitCamera : MonoBehaviour {
    [SerializeField]
    private Transform target;
    public float rotSpeed= .1f;
    public float vrotSpeed = .1f;
    public float _rotY;
    private float _rotX;
    private Vector3 _offset;
	// Use this for initialization
	void Start () {
        _rotY = transform.eulerAngles.y;
        _rotX = transform.eulerAngles.x;
        _offset = target.position - transform.position;
	}

    // Update is called once per frame
    void LateUpdate () {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        if (horInput != 0)
        {
            _rotY += horInput * rotSpeed;
        }
        if (verInput >= 0 || verInput <= 0)
        {
            _rotX += Input.GetAxis("Mouse Y") * vrotSpeed * 3;
           if (_rotX >= 20)
            {
                _rotX = 20;
            }
            if (_rotX <= -5)
            {
                _rotX = -5;
            }
       //     else
        //    {
         //       _rotX += verInput * rotSpeed;
         //   }
        }
        if (horInput == 0)
        {

            _rotY += Input.GetAxis("Mouse X") * rotSpeed * 3;

        }
        Quaternion rotation = Quaternion.Euler (_rotX, _rotY, 0);
        transform.position = target.position - (rotation * _offset);
        transform.LookAt(target);
	}
}
