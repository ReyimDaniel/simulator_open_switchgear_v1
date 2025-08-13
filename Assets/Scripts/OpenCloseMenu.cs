using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseMenu : MonoBehaviour
{
    [SerializeField] public Canvas canvasMenu;
    [SerializeField] public Canvas teh1CloseMenu;
    [SerializeField] public Canvas teh2OpenMenu;

    public void CloseMenu()
    {
        canvasMenu.enabled = false;
        teh1CloseMenu.enabled = false;
        teh2OpenMenu.enabled = true;
    }
    public void OpenMenu()
    {
        canvasMenu.enabled = true;
        teh1CloseMenu.enabled = true;
        teh2OpenMenu.enabled = false;
    }
}
