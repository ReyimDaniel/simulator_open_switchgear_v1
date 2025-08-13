using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnMonitor : MonoBehaviour
{
    [SerializeField] public GameObject textikContr;
    [SerializeField] public GameObject instrPanel;
    public void ShowTextik()
    {
        instrPanel.SetActive(false);
        textikContr.SetActive(!textikContr.activeSelf);
    }

    public void ShowTextik2()
    {
        textikContr.SetActive(false);
        instrPanel.SetActive(!instrPanel.activeSelf);
    }
}