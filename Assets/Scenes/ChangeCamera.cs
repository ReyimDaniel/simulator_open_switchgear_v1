using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera TheCamera;
    public Camera Cam;
    void Start()
    {
        TheCamera= GetComponent<Camera>();
        TheCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    public void ChangeView()
    {
        TheCamera.enabled = !TheCamera.enabled;
        Cam.enabled = !Cam.enabled;
    }
}
