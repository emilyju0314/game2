using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    private int playerCount;
    public GameObject canvas_;
    public changeText text_;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        text_ = new changeText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            changeScene();
        playerCount = GameObject.FindGameObjectsWithTag("Player").Length;
        Debug.Log(Time.timeScale);
        if(playerCount == 1)
        {
            Time.timeScale = 0;
            canvas_.SetActive(true);
            //GameObject.Find("changeText").SendMessage("changetext");
            //text_.changetext(GameObject.FindGameObjectsWithTag("Player").ToString());
        }
    }

    internal static void LoadScene(string v)
    {
        throw new NotImplementedException();
    }
    public void changeScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        canvas_.SetActive(false);
    }
}
