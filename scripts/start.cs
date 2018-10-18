using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class start : MonoBehaviour {
    [SerializeField]
    public Transform canvas;
    // Use this for initialization
    public Button mybutton;
    [SerializeField]
    public Transform Player;
    // Use this for initialization]
    private void Start()
    {
        Button btn = mybutton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
        }
        Player.GetComponent<sceneloader>().enabled = true;
        //     SceneManager.LoadScene("lvl 1");

    }

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

}
