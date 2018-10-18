using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour {
    private bool loadsceene = false;
    // Use this for initialization
    [SerializeField]
    public int scene;
    [SerializeField]
    private Text loadingText;
    [SerializeField]
    private Text done;
    private float timer = 0;
	// Update is called once per frame
	void Update () {
        SceneManager.LoadScene(scene);
        timer = Time.deltaTime;
        if (timer >= 1.0f && timer <= 1.1f)
        {
            loadingText.text = "loading.";
        }
        if (timer >= 1.5f && timer <= 1.6f)
        {
            loadingText.text = "loading..";
        }
        if (timer >= 2.0f && timer <= 2.1f)
        {
            loadingText.text = "loading...";
        }
        if (timer >= 2.5f)
        {
            timer = 0;
            loadingText.text = "loading";
        }
        if (Input.GetKeyUp(KeyCode.Space) && loadsceene == false)
        {
            loadsceene = true;
            StartCoroutine(loadNewScene());

        }
        if (loadsceene == true)
        {
        }
	}
    IEnumerator loadNewScene()
    {
        yield return new WaitForSeconds(3);
    }
}
