using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMainMenu : MonoBehaviour
{
    public void ButtonPlay()
    {
        SceneManager.LoadScene(0);
    }
    public void ButtunBack()
    {
        SceneManager.LoadScene(1);
    }
}
