using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uıController : MonoBehaviour
{
    public GameObject scoretext;
    
    public int scoreleft;
    public int scoreright;
    private bool endflag;
    
    public int  scorelimit = 5;
    
    [SerializeField] private string endlevelname;
    [SerializeField] private string mainmanulevelname;
    void Start()
    {
        updatescore();
        endflag = false;
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void updatescore()
    {
        
        scoretext.GetComponent<TextMeshProUGUI>().text = $"{scoreleft}-{scoreright}";
        if(scoreleft == scorelimit||scoreright == scorelimit)
        {
            endflag = true;
            SceneManager.LoadScene(endlevelname);
            
        }
    }

    private void Update()
    {
        
        if (endflag&&Input.anyKeyDown)
        {
            SceneManager.LoadScene(mainmanulevelname);
            Destroy(gameObject);
        }
    }

    public void addScoreleft()
    {
        scoreleft++;
        updatescore();
    }

    public void addScoreright()
    {
        scoreright++;
        updatescore();
    }
    void resetscore()
    {
        scoreleft = 0;
        scoreright = 0;
        updatescore();
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == endlevelname)
        {
            GameObject canvasObj = GameObject.Find("Canvas");
            GameObject winTextObj = canvasObj.transform.Find("WinText").gameObject;
            if (winTextObj != null)
            {
                TextMeshProUGUI tmp = winTextObj.GetComponent<TextMeshProUGUI>();
                if (tmp != null)
                {
                    if(scoreleft>scoreright)
                    {
                        tmp.text = "LEFT WINS";
                    }
                    else if (scoreleft < scoreright)
                    {
                        tmp.text = "RIGHT WINS";
                    }
                    else
                    {
                        tmp.text = "It's a Tie";
                    }
                }
            }

            SceneManager.sceneLoaded -= OnSceneLoaded;
        }
    }
    
    
    
}
