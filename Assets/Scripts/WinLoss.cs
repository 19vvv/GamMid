using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoss : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene(0);
    }

    public void WinGame(){
        SceneManager.LoadScene(1);
    }

    public void LossGame(){
        SceneManager.LoadScene(2);
    }

    public void MenuGame(){
        SceneManager.LoadScene(3);
    }

    public void Rules(){
        SceneManager.LoadScene(4);
    }
}