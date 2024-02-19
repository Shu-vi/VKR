using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoToHome()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToLevel1()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene(4);
    }
}
