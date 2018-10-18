using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossAI : MonoBehaviour
{
    [SerializeField]
    private GameObject firebalPrefab;
    private GameObject _fireball;
    private GameObject _fireball1;
    private GameObject _fireball2;
    private GameObject _fireball3;
    public float speed = 5.0f;
    public float obstacleRange = 25.0f;
    public float minRange = 3.0f;
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


    void Update()
    {

        if (_alive)
        {
            agent.SetDestination(target.position);
            _charController.SimpleMove(0 * transform.forward);
            timeer += Time.deltaTime;
            if (timeer >= 3)
            {
                timeer = 0;
                if (_fireball == null)
                {
                    _fireball = Instantiate(firebalPrefab) as GameObject;
                    _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                 //   _fireball.transform.rotation = transform.rotation;
                }
              //  if (_fireball1 == null)
          //      {
            //        _fireball1 = Instantiate(firebalPrefab) as GameObject;
           //        _fireball1.transform.position = transform.TransformPoint(Vector3.up * 1.5f);
           //         _fireball1.transform.rotation = transform.rotation;
          //      }
           //     if (_fireball2 == null) { 
         //           _fireball2 = Instantiate(firebalPrefab) as GameObject;
         //       _fireball2.transform.position = transform.TransformPoint(Vector3.right * 1.5f);
        //        _fireball2.transform.rotation = transform.rotation;
        //    }
       //         if (_fireball3 == null)
        //        {
         //           _fireball3 = Instantiate(firebalPrefab) as GameObject;
         //           _fireball3.transform.position = transform.TransformPoint(Vector3.left * 1.5f);
         //           _fireball3.transform.rotation = transform.rotation;
         //       }

            }
                    }
                }
            
            //    if (health <= 0)
            //      {
            //            _alive = false;
            //           Destroy(this.gameObject);            }
        
    


    //  public void Hit()
    // {
    //      health = health - 1;
    //  }
    public void SetAlive(bool alive)
    {
        _alive = alive;

    }
}
