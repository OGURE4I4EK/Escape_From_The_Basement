using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuContoller : MonoBehaviour
{
    public void ButtonPlay()
    {
        SceneManager.LoadScene("Game");        
    }
    public void ButtonExit()
    {
        Application.Quit();
    }
}