using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restartGamesc : MonoBehaviour
{
  

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void restartTheGame()
    {
        SceneManager.LoadScene("EndScreen");
    }



}
