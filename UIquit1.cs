using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIquit : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        
    }

    public void Launch()
    {
        SceneManager.LoadScene("SampleScene");
    }



    public void Exit(){
        SceneManager.LoadScene("Menu");
    }
}
