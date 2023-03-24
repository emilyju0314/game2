using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    GameObject background;
    bool start_ = false;
    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("background");
    }
    private void FixedUpdate()
    {
        if (start_ == true)
        {
            background.GetComponent<SpriteRenderer>().color = Color.Lerp(background.GetComponent<SpriteRenderer>().color, Color.black, Time.deltaTime * 0.5f);
        }
    }

    public void startClick()
    {
        start_ = true;
        GameObject.Find("起始文字").GetComponent<Text>().enabled = true;
       // Debug.Log("可以");
        GameObject.Find("exit").GetComponentInChildren<Text>().enabled = false;
        GameObject.Find("start").GetComponentInChildren<Text>().enabled = false;
        Invoke("changeScene", 6);
    }
    public void exitClick()
    {
        Debug.Log("exit");
        Application.Quit();
    }
    void changeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
