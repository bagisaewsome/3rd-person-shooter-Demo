using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretAI : MonoBehaviour {
    [SerializeField]
    private GameObject firebalPrefab;
    private GameObject _fireball;
    private GameObject _fireball1;
    private GameObject _fireball2;
    private GameObject _fireball3;
    private GameObject _fireball4;
    private GameObject _fireball5;
    public float speed = 8.0f;
    public float obstacleRange = 5.0f;
    public int damage = 1;
    // Use this for initialization
    private bool _alive;
    private float _vertSpeed;
    public Transform target;
   // UnityEngine.AI.NavMeshAgent agent;
    ranpidenty player;
    public float health;
    private CharacterController _charController;
    void Start()
    {
        _alive = true;
        target = GameObject.FindWithTag("Player").transform;
        _charController = GetComponent<CharacterController>();
    //    agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    float timeer;
    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        playerchara player = other.GetComponent<playerchara>();
        //   if (player != null)
        //  {
        //   ReactiveTarget target = this.GetComponent<ReactiveTarget>();
        //   target.ReactToHit();
        //      player.Hurt(damage);
        //  }
    }
    void Update()
    {

        if (_alive)
        {
            transform.LookAt(target);
         //   agent.SetDestination(target.position);
          //  _charController.SimpleMove(0 * transform.forward);
            timeer += Time.deltaTime;
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (timeer >= 1f)
            {
                timeer = 0;
            }
            if (Physics.SphereCast(ray, .75f, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                if (hit.distance < obstacleRange)
                {
                    if (hitObject.GetComponent<playerchara>())
                    {
                        if (_fireball == null && timeer >= 0.25f && timeer < 0.3f)
                        {
                            _fireball = Instantiate(firebalPrefab) as GameObject;
                            _fireball.transform.position = transform.TransformPoint( new Vector3(0, 1, 1.8f) /*.forward * 1.5f*/);
                            _fireball.transform.LookAt(target);
                          //  timeer = 0f;
                        }
                        if (_fireball1 == null && timeer >= .5f && timeer < .55f)
                        {
                            _fireball1 = Instantiate(firebalPrefab) as GameObject;
                            _fireball1.transform.position = transform.TransformPoint(new Vector3(0, 1, 1.8f) /*.forward * 1.5f*/);
                            _fireball1.transform.LookAt(target);
                         //   timeer = 0f;
                        }
                        if (_fireball2 == null && timeer >= .75f && timeer < .8f)
                        {
                            _fireball2 = Instantiate(firebalPrefab) as GameObject;
                            _fireball2.transform.position = transform.TransformPoint(new Vector3(0, 1, 1.8f) /*.forward * 1.5f*/);
                            _fireball2.transform.LookAt(target);
                            //   timeer = 0f;
                        }
                    }
                }

            }
            //    if (health <= 0)
            //      {
            //            _alive = false;
            //           Destroy(this.gameObject);            }
        }
    }


    //  public void Hit()
    // {
    //      health = health - 1;
    //  }
    public void SetAlive(bool alive)
    {
        _alive = alive;
    }
}
