using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubuttoncontroller : MonoBehaviour
{
    [SerializeField] private string levelname;
    public void startgame()
    {
       SceneManager.LoadScene(levelname);
    }
}
