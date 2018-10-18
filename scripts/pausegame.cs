using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausegame : MonoBehaviour {
    public Transform canvas;
    public Transform Player;
    public Transform GUn;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive  (true);
                Time.timeScale = 0;
                Player.GetComponent<ORbitCamera>().enabled = false;
                GUn.GetComponent<gunfromcamera>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
                Player.GetComponent<ORbitCamera>().enabled = true;
                GUn.GetComponent<gunfromcamera>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
	}
    public void pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            Player.GetComponent<ORbitCamera>().enabled = false;
            GUn.GetComponent<gunfromcamera>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Player.GetComponent<ORbitCamera>().enabled = true;
            GUn.GetComponent<gunfromcamera>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}