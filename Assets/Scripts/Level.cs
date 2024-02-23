using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    
    public void GoToHome()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel(int number)
    {
        SceneManager.LoadScene(number);
    }
}
