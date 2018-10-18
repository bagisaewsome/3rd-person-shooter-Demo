using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]

public class wanderAI : MonoBehaviour {
    [SerializeField] private GameObject firebalPrefab;
    private GameObject _fireball;
    public float speed = 5.0f;
    public float obstacleRange = 5.0f;
    public int damage = 1;
    // Use this for initialization
    private bool _alive;
    private float _vertSpeed;
    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;
    ranpidenty player;
    public float health;
    private CharacterController _charController;
    void Start()
    {
        _alive = true;
         target = GameObject.FindWithTag("Player").transform;
        _charController = GetComponent<CharacterController>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); 
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
    void Update () {
        
        if (_alive)
        {
            agent.SetDestination(target.position);
            _charController.SimpleMove(0 * transform.forward);
    timeer += Time.deltaTime;
                Ray ray = new Ray(transform.position, transform.forward);
                RaycastHit hit;
            if (Physics.SphereCast(ray, .75f, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                if (hit.distance < obstacleRange)
                {
                    if (hitObject.GetComponent<playerchara>())
                    {
                        if (_fireball == null && timeer >= 2)
                        {
                            _fireball = Instantiate(firebalPrefab) as GameObject;
                            _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                            _fireball.transform.rotation = transform.rotation;
                            timeer = 0f;
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
