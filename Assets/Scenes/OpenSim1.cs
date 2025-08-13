using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenSim1 : MonoBehaviour
{
    public void Sim1()
    {
        SceneManager.LoadScene(1);
    }
    public void Sim2()
    {
        SceneManager.LoadScene(2);
    }
    public void Sim3()
    {
        SceneManager.LoadScene(3);
    }
    public void Sim4()
    {
        SceneManager.LoadScene(4);
    }
    public void ButtunBack()
    {
        SceneManager.LoadScene(0);
    }
}
