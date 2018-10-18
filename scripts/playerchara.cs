using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerchara : MonoBehaviour {
    public float _health;
    private float timetake;
    public float ammo;
    public Text endtext;
    float precentage;
    public Text healthtext;
    public GameObject healthbar;
    [SerializeField]
    gunfromcamera ammmo;
    [SerializeField]
    public Text objective;
    // Use this for initialization
    void Start () {
        _health = 20;
     //   ammo = 50;
        gunfromcamera ammmo = GetComponent<gunfromcamera>();
    }
    private void OnTriggerEnter(Collider other)
    {
        walltrigger playerr = other.GetComponent<walltrigger>();
        if (playerr != null)
        {
            objective.text = "find a white button to open the door";
        }
    }
    private void OnTriggerExit(Collider other)
    {
   //     walltrigger playerr = other.GetComponent<walltrigger>();
   //     if (playerr != null)
    //    {
    //        objective.text = "continue through the valley";
     //   }
    }
    public void reload()
    {
        ammo = ammmo.amo;
        //   gunfromcamera playerg = other.GetComponent<gunfromcamera>();
        //    if (player != null)
        //   {
        if (ammo <= 40)
        {
            ammo = ammo + 10;
            Debug.Log(ammmo + " + 10");
                   ammmo.amo = ammo + 10;
        }
        if (ammo > 40)
        {
            ammo = 50;
            Debug.Log(ammo + " is 50");
            //      playerg.amo = 50;
            ammmo.amo = ammo;
        }
    }
    private void Update()
    {
        ammo = ammmo.amo;
        Debug.Log(ammo);
        string lives = _health.ToString();
        healthtext.text = "health: " + lives;
        precentage = _health / 20;
        Debug.Log(precentage);
        healthbar.transform.localScale = new Vector3(precentage, 1, 1);
        // if (Input.GetKey("escape"))
        //   {
        //        Application.Quit();
        //   }

    }

    // Update is called once per frame
    public void Hurt (int damage) {
        _health -= damage;
        Debug.Log(" health: " + _health);
        precentage = _health / 20;
        Debug.Log(precentage);
        healthbar.transform.localScale = new Vector3(precentage, 1, 1);
        if (_health <= 0)
        {
            timetake = Time.realtimeSinceStartup;
            endtext.text = "YOU DIED!!!";
            StartCoroutine(Die());
            _health = 30;

        }

    }
    private IEnumerator Die()
    {
        transform.position = new Vector3(2.1f, -116.3f, 97.96f);
        yield return new WaitForSeconds(2);
       SceneManager.LoadScene("open");



    }
}
