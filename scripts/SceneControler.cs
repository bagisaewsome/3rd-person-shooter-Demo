using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControler : MonoBehaviour {
    [SerializeField]
    private GameObject targetPrefab;
    [SerializeField]
    private GameObject sacrificePrefab;
    [SerializeField]
    public gunfromcamera list;
    [SerializeField]
    startenemy Spawn;
    private GameObject _enemy;
    private GameObject _enemy1;
    private GameObject _enemy2;
    private GameObject _enemy3;
    private GameObject _enemy4;
    private GameObject _enemy5;
    private GameObject _enemy6;
    private GameObject _enemy7;
    private GameObject _bar;
    private GameObject _bar1;
    private GameObject _bar2;
    private GameObject _bar3;
    private GameObject _bar4;
    private GameObject _bar5;
    private GameObject _bar6;
    private GameObject _bar7;
    public float timer = 0.0f;

    //  [SerializeField]
    //  public 
    private void Start()
    {
        Spawn.GetComponent<startenemy>();
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Spawn.GetComponent<startenemy>();
        // was = GameObject.Find("enemyone").Wave;
        if (Spawn.Wave == true)
        {
            if (timer > 4)
            {
                timer = 0.0f;
                list.GetComponent<gunfromcamera>();
                if (_enemy == null)
                {
                    list.updated = false;
                    _enemy = Instantiate(sacrificePrefab) as GameObject;
                  //  _bar = Instantiate(barPrefab) as GameObject;
                 //   _bar.transform.parent = GameObject.Find("healthbar").transform;
                    float start = Random.Range(0, 7);
                    if (start <= 1 && start >= 0)
                    {
                        _enemy.transform.position = new Vector3(-13, 1, 43);
                    }
                    if (start <= 2 && start > 1)
                    {
                        _enemy.transform.position = new Vector3(23, 1, -13);
                    }
                    if (start <= 3 && start > 2)
                    {
                        _enemy.transform.position = new Vector3(-13, 1, 23);
                    }
                    if (start <= 4 && start > 3)
                    {
                        _enemy.transform.position = new Vector3(-23, 1, 29);
                    }
                    if (start <= 5 && start > 4)
                    {
                        _enemy.transform.position = new Vector3(-31, 1, 18);
                    }
                    if (start <= 6 && start > 5)
                    {
                        _enemy.transform.position = new Vector3(1, 1, -46);
                    }
                    if (start <= 7 && start > 6)
                    {
                        _enemy.transform.position = new Vector3(-46, 1, 1);
                    }
                }
                if (_enemy1 == null)
                {
                    //  _bar1 = Instantiate(barPrefab) as GameObject;
                    _enemy1 = Instantiate(targetPrefab) as GameObject;
                    // _bar1.transform.parent = GameObject.Find("healthbar").transform;
                    list.updated = false;
                    float start = Random.Range(0, 7);
                    if (start <= 1 && start >= 0)
                    {
                        _enemy1.transform.position = new Vector3(-13, 1, 43);
                    }
                    if (start <= 2 && start > 1)
                    {
                        _enemy1.transform.position = new Vector3(23, 1, -13);
                    }
                    if (start <= 3 && start > 2)
                    {
                        _enemy1.transform.position = new Vector3(-13, 1, 23);
                    }
                    if (start <= 4 && start > 3)
                    {
                        _enemy1.transform.position = new Vector3(-23, 1, -45);
                    }
                    if (start <= 5 && start > 4)
                    {
                        _enemy1.transform.position = new Vector3(-7, 1, -6);
                    }
                    if (start <= 6 && start > 5)
                    {
                        _enemy1.transform.position = new Vector3(1, 1, -46);
                    }
                    if (start <= 7 && start > 6)
                    {
                        _enemy1.transform.position = new Vector3(-46, 1, 1);
                    }
                }
                if (_enemy2 == null)
                {
                    //   _bar2 = Instantiate(barPrefab) as GameObject;
                    //   _bar2.transform.parent = GameObject.Find("healthbar").transform;
                    _enemy2 = Instantiate(targetPrefab) as GameObject;
                    list.updated = false;
                    float start = Random.Range(0, 7);
                    if (start <= 1 && start >= 0)
                    {
                        _enemy2.transform.position = new Vector3(-13, 1, 43);
                    }
                    if (start <= 2 && start > 1)
                    {
                        _enemy2.transform.position = new Vector3(23, 1, -13);
                    }
                    if (start <= 3 && start > 2)
                    {
                        _enemy2.transform.position = new Vector3(-13, 1, 23);
                    }
                    if (start <= 4 && start > 3)
                    {
                        _enemy2.transform.position = new Vector3(-23, 1, -45);
                    }
                    if (start <= 5 && start > 4)
                    {
                        _enemy2.transform.position = new Vector3(-1, 1, -1);
                    }
                    if (start <= 6 && start > 5)
                    {
                        _enemy2.transform.position = new Vector3(1, 1, -46);
                    }
                    if (start <= 7 && start > 6)
                    {
                        _enemy2.transform.position = new Vector3(-46, 1, 1);
                    }
                }
                if (_enemy3 == null)
                {
                    //       _bar3 = Instantiate(barPrefab) as GameObject;
                    //      _bar3.transform.parent = GameObject.Find("healthbar").transform;
                    _enemy3 = Instantiate(sacrificePrefab) as GameObject;
                    list.updated = false;
                    float start = Random.Range(0, 7);
                    if (start <= 1 && start >= 0)
                    {
                        _enemy3.transform.position = new Vector3(-13, 1, 43);
                    }
                    if (start <= 2 && start > 1)
                    {
                        _enemy3.transform.position = new Vector3(23, 1, -13);
                    }
                    if (start <= 3 && start > 2)
                    {
                        _enemy3.transform.position = new Vector3(-13, 1, 23);
                    }
                    if (start <= 4 && start > 3)
                    {
                        _enemy3.transform.position = new Vector3(-23, 1, -45);
                    }
                    if (start <= 5 && start > 4)
                    {
                        _enemy3.transform.position = new Vector3(-1, 1, -1);
                    }
                    if (start <= 6 && start > 5)
                    {
                        _enemy3.transform.position = new Vector3(1, 1, -46);
                    }
                    if (start <= 7 && start > 6)
                    {
                        _enemy3.transform.position = new Vector3(-46, 1, 1);
                    }
                }
                if (_enemy4 == null)
                {
                    //   _bar4 = Instantiate(barPrefab) as GameObject;
                    //    _bar4.transform.parent = GameObject.Find("healthbar").transform;
                    _enemy4 = Instantiate(sacrificePrefab) as GameObject;
                    list.updated = false;
                    float start = Random.Range(0, 7);
                    if (start <= 1 && start >= 0)
                    {
                        _enemy4.transform.position = new Vector3(-13, 1, 43);
                    }
                    if (start <= 2 && start > 1)
                    {
                        _enemy4.transform.position = new Vector3(23, 1, -13);
                    }
                    if (start <= 3 && start > 2)
                    {
                        _enemy4.transform.position = new Vector3(-13, 1, 23);
                    }
                    if (start <= 4 && start > 3)
                    {
                        _enemy4.transform.position = new Vector3(-23, 1, -45);
                    }
                    if (start <= 5 && start > 4)
                    {
                        _enemy4.transform.position = new Vector3(-1, 1, -1);
                    }
                    if (start <= 6 && start > 5)
                    {
                        _enemy4.transform.position = new Vector3(1, 1, -46);
                    }
                    if (start <= 7 && start > 6)
                    {
                        _enemy4.transform.position = new Vector3(-46, 1, 1);
                    }
                }
                if (_enemy5 == null)
                {
                    //        _bar5 = Instantiate(barPrefab) as GameObject;
                    //        _bar5.transform.parent = GameObject.Find("healthbar").transform;
                    _enemy5 = Instantiate(targetPrefab) as GameObject;
                    list.updated = false;
                    float start = Random.Range(0, 7);
                    if (start <= 1 && start >= 0)
                    {
                        _enemy5.transform.position = new Vector3(-33, 1, -43);
                    }
                    if (start <= 2 && start > 1)
                    {
                        _enemy5.transform.position = new Vector3(-5, 1, -23);
                    }
                    if (start <= 3 && start > 2)
                    {
                        _enemy5.transform.position = new Vector3(-13, 1, 27);
                    }
                    if (start <= 4 && start > 3)
                    {
                        _enemy5.transform.position = new Vector3(23, 1, -25);
                    }
                    if (start <= 5 && start > 4)
                    {
                        _enemy5.transform.position = new Vector3(1, 1, 6);
                    }
                    if (start <= 6 && start > 5)
                    {
                        _enemy5.transform.position = new Vector3(1, 1, -36);
                    }
                    if (start <= 7 && start > 6)
                    {
                        _enemy5.transform.position = new Vector3(-36, 1, 1);
                    }
                }
                if (_enemy6 == null)
                {
                    ///        _bar6 = Instantiate(barPrefab) as GameObject;
                    //        _bar6.transform.parent = GameObject.Find("healthbar").transform;
                    _enemy6 = Instantiate(targetPrefab) as GameObject;
                    list.updated = false;
                    float start = Random.Range(0, 7);
                    if (start <= 1 && start >= 0)
                    {
                        _enemy6.transform.position = new Vector3(-13, 1, 43);
                    }
                    if (start <= 2 && start > 1)
                    {
                        _enemy6.transform.position = new Vector3(23, 1, -13);
                    }
                    if (start <= 3 && start > 2)
                    {
                        _enemy6.transform.position = new Vector3(-13, 1, 23);
                    }
                    if (start <= 4 && start > 3)
                    {
                        _enemy6.transform.position = new Vector3(-23, 1, -45);
                    }
                    if (start <= 5 && start > 4)
                    {
                        _enemy6.transform.position = new Vector3(-7, 1, -31);
                    }
                    if (start <= 6 && start > 5)
                    {
                        _enemy6.transform.position = new Vector3(1, 1, -46);
                    }
                    if (start <= 7 && start > 6)
                    {
                        _enemy6.transform.position = new Vector3(-46, 1, 1);
                    }
                }
                if (_enemy7 == null)
                {
                    //        _bar7 = Instantiate(barPrefab) as GameObject;
                    //        _bar7.transform.parent = GameObject.Find("healthbar").transform;
                    _enemy7 = Instantiate(targetPrefab) as GameObject;
                    list.updated = false;
                    float start = Random.Range(0, 7);
                    if (start <= 1 && start >= 0)
                    {
                        _enemy7.transform.position = new Vector3(-43, 1, 23);
                    }
                    if (start <= 2 && start > 1)
                    {
                        _enemy7.transform.position = new Vector3(23, 1, -43);
                    }
                    if (start <= 3 && start > 2)
                    {
                        _enemy7.transform.position = new Vector3(-13, 1, 23);
                    }
                    if (start <= 4 && start > 3)
                    {
                        _enemy7.transform.position = new Vector3(-23, 1, -45);
                    }
                    if (start <= 5 && start > 4)
                    {
                        _enemy7.transform.position = new Vector3(45, 1, -37);
                    }
                    if (start <= 6 && start > 5)
                    {
                        _enemy7.transform.position = new Vector3(1, 1, -46);
                    }
                    if (start <= 7 && start > 6)
                    {
                        _enemy7.transform.position = new Vector3(-46, 1, 1);
                    }
                }
            }
        }
    }
}
