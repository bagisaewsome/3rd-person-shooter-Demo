using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]


public class playermove : MonoBehaviour {
    [SerializeField]
    private Transform target;
    private ControllerColliderHit  _contact;
    public float rotSpeed = 15.0f;
    public float movespeed = 6.0f;
    public float _rotY;
    public float _rotZ;
    public float jumpspeed = 15.0f;
    public float gravity = -9.8f;
    public float terminalVelocity = -10.0f;
    public float minFall = -1.5f;
    private float _vertSpeed;
    private Animator _animator;
    Vector3 movement = Vector3.zero;
	// Use this for initialization
	void Start () {
        _charController = GetComponent<CharacterController>();
        _vertSpeed = minFall;
        _animator = GetComponent<Animator>();
	}

    private CharacterController _charController;

    // Update is called once per frame
    void Update () {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        if (horInput != 0 || verInput != 0)
        {
            //movement
            movement.x = horInput * movespeed;
            movement.z = verInput * movespeed;
            //
            //rotation
            Quaternion tmp = target.rotation;
            target.eulerAngles = new Vector3(0, target.eulerAngles.y, 0);
              movement = target.TransformDirection(movement);
           // movement = target.eulerAngles;
            target.rotation = tmp;
            Quaternion direction = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, direction, rotSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(new Vector3(0f, transform.rotation.eulerAngles.y, 0f));
       //     if (transform.rotation.x > 0 || transform.rotation.x < 0)
          //  {
          //        transform.rotation = Quaternion.Euler(0, target.eulerAngles.y, 0);
         //   }

            //
        }
        _animator.SetFloat("Speed", movement.sqrMagnitude);
        bool hitGround = false;
        RaycastHit hit;
        if (_vertSpeed < 0 && Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            float check = (_charController.height + _charController.radius) / 1.9f;
            hitGround = hit.distance <= check;
        }
        if (hitGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _vertSpeed = jumpspeed;
            }
            else
            {
                _vertSpeed = minFall;
                _animator.SetBool("jumping", false);
             }
        }
        else {
            _vertSpeed += gravity * 5 * Time.deltaTime;
            if (_vertSpeed < terminalVelocity)
            {
                _vertSpeed = terminalVelocity;
            }
            if (_contact != null)
            {
                _animator.SetBool("jumping", true);
            }
            if (_charController.isGrounded)
             {
            if (Vector3.Dot(movement, _contact.normal) < 0)
            {
                movement = _contact.normal * movespeed;
            }
            else
            {
            movement += _contact.normal * movespeed;
                }
        }
        }
        movement.y = _vertSpeed;

        movement *= Time.deltaTime;
        _charController.Move(movement);
	}
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        _contact = hit;
    }
}
