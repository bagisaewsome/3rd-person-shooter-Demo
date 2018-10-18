using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using UnityEngine.UI;


public class startenemy : MonoBehaviour {
    public bool Wave;
    public float timer;
    public bool Up;
    private bool on = false;
    private bool boss;
    [SerializeField]
    raiseplatform raise;
    [SerializeField]
    public Text objective;
    [SerializeField]
    private GameObject bossPrefab;
    private GameObject _boss;
    private void Start()
    {
        Wave = false;
        Up = false;
        boss = false;
    }
    public void Operate()
    {
        Color random = new Color(Random.Range(0f, 1f),
            Random.Range(0f, 1f), Random.Range(0f, 1f));
        GetComponent<Renderer>().material.color = random;
        runn();
        on = true;
       // Debug.Log(Wave);
    }
    public void Update()
    {
        if (on)
        {
            timer += Time.deltaTime;
            //var clock = (300 - timer);
            float minutes = Mathf.Floor(timer / 60);
            string minuetes = minutes.ToString("00");
            float seconds = (timer % 60);
            string seeconds = seconds.ToString("00");


                //       var countdown = Math.Round(clock, 3);
            objective.text = "wait for the extraction pad to apper in 5 min. Current Time " + minuetes + ":" + seeconds;
        }
        raise.GetComponent<raiseplatform>();

        if (timer >= 300 && Up != true)
        {
            objective.text = "get to the extraction pad!";
            raise.move();
            Up = true;
        }
        if (timer >= 180 && boss != true)
        {
           _boss = Instantiate(bossPrefab) as GameObject;
            _boss.transform.position = new Vector3(0, 1, 45);
            boss = true;
        }
    }
    private void runn()
    {
        Wave = true;
    }
}
