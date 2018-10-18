using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class gunfromcamera : MonoBehaviour
{
    //  private Camera _camera;
    public float obstacleRange = 28.0f;
    LineRenderer laserline;
    // public Transform target;
    //   public Transform targeta;
    public List<Transform> Enemies;
    public Transform SelectedTarget;
    public float timer;
    public float delay;
    public GameObject ammobar;
    float precentage;
    public float amo;
    [SerializeField]
    playerchara ammmo;
    public Text ammotext;
    public Text rangestatus;
    public bool updated = false;
    public Quaternion originalRotationValue; // declare this as a Quaternion
    float rotationResetSpeed = 1.0f;
    // Use this for initialization
    void Start()
    {
        //   _camera = GetComponent<Camera>();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        laserline = GetComponent<LineRenderer>();
        // target = GameObject.FindWithTag("enemy").transform;
        Invoke("runlist", 0);
        delay = 0f;
        originalRotationValue = transform.rotation;
        playerchara ammmo = GetComponent<playerchara>();
     //   amo = 50;
    }
    public void runlist()
    {
        SelectedTarget = null;
        Enemies = new List<Transform>();
        AddEnemiesToList();
    }
    public void AddEnemiesToList()
    {
        GameObject[] ItemsInList = GameObject.FindGameObjectsWithTag("enemy");
        foreach (GameObject _Enemy in ItemsInList)
        {
            AddTarget(_Enemy.transform);
        }
    }

    public void AddTarget(Transform enemy)
    {
        Enemies.Add(enemy);
    }

    public void DistanceToTarget()
    {
        //  if (SelectedTarget == null)
        //     {

        if (Enemies[0] == null)
        {
            var topolist = Enemies[0];
            Enemies.Remove(topolist);
        }
        if (Enemies[1] == null)
        {
            var topolist = Enemies[1];
            Enemies.Remove(topolist);
        }
        if (Enemies[2] == null)
        {
            var topolist = Enemies[2];
            Enemies.Remove(topolist);
        }
            if (Enemies[3] == null)
              {
                var topolist = Enemies[3];
                Enemies.Remove(topolist);
             }

        Debug.Log("sorting");
        Enemies.Sort(delegate (Transform t1, Transform t2)
        {
            return Vector3.Distance(t1.transform.position, this.transform.position).CompareTo(Vector3.Distance(t2.transform.position, this.transform.position));
        });
        //   }
    }
    public void TargetedEnemy()
    {
        DistanceToTarget();
        //  Debug.Log("target found");
          if (Enemies[0] != null)
           {
        SelectedTarget = Enemies[0];
            }
            if (SelectedTarget == null)
             {
                 SelectedTarget = Enemies[1];
             }
    }
    // Update is called once per frame
    void Update()
    {
        amo = ammmo.ammo;

        precentage = amo / 50;
        // Debug.Log(precentage);
        ammobar.transform.localScale = new Vector3(precentage, 1, 1);
        if (SelectedTarget == null)
        {
            updated = false;
        }
        transform.LookAt(SelectedTarget);
        if (amo <= 0)
        {
            ammotext.text = "energy: 0";
            rangestatus.text = "weak short range only";
        }
        else
        {
            ammotext.text = "energy: " + amo;
           rangestatus.text = "short and long range at max power";
        }
        delay += Time.deltaTime;
        if (updated != true)
        {
            AddEnemiesToList();
            updated = true;
        }
        TargetedEnemy();
        //    AddEnemiesToList();
        laserline.SetPosition(0, transform.position);
        timer += Time.deltaTime;
        if (timer >= .1f)
        {

            laserline.enabled = false;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (amo <= 0)
            {
                ammotext.text = "energy: 0";
                rangestatus.text = "weak short range only";
                updated = false;
            }
            else
            {
                ammotext.text = "energy: " + amo;
                rangestatus.text = "short and long range at max power";
                updated = false;
            }
            updated = false;
            shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (amo <= 0)
            {
               ammotext.text = "energy: 0";
                transform.LookAt(SelectedTarget);
                shoot();
                rangestatus.text = "short range  only";
                updated = false;
            }
            else
            {
                ammotext.text = "energy: " + amo;
                transform.LookAt(SelectedTarget);
                       rangestatus.text = "short and long range at max power";
                updated = false;
                shoott();
            }

        }
    }



    private void shoot()
    {
        if (delay >= .7f)
        {
        timer = 0f;
        //  Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2);
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (amo <= 0)
            {
                obstacleRange = 8.0f;
            }
        if (amo > 0)
            {
                obstacleRange = 28.0f;
            }
        if (Physics.Raycast(ray, out hit, obstacleRange))
        {
                if (amo > 0)
                {
                    amo -= 1;
                }
                precentage = amo / 50;
                // Debug.Log(precentage);
                ammobar.transform.localScale = new Vector3(precentage, 1, 1);
                laserline.enabled = true;
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                laserline.SetPosition(1, hit.point);
                if (target != null)
                {
                    Debug.Log("hit");
                    target.ReactToHitL();
                    Enemies = new List<Transform>();
                    updated = false;
                }
                delay = 0f;
            }
        }
    }
    private void shoott()
    {
        if (delay >= .7f)
        {
            timer = 0f;
            //  Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2);
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
                obstacleRange = 8.0f;
            if (Physics.Raycast(ray, out hit, obstacleRange))
            {
                laserline.enabled = true;
                if (amo > 0)
                {
                    amo -= 1;
                }
                precentage = amo / 50;
                // Debug.Log(precentage);
                ammobar.transform.localScale = new Vector3(precentage, 1, 1);
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                laserline.SetPosition(1, hit.point);
                if (target != null)
                {
                    Debug.Log("hit");;
                    target.ReactToHitS();
                    Enemies = new List<Transform>();
                    updated = false;
                }
                delay = 0f;
            }
        }
    }
}
   

