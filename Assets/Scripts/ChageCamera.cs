using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChageCamera : MonoBehaviour
{
        [SerializeField] public Camera camera1;
        [SerializeField] public Camera camera2;

       
       public void SwitchCamerasInError()
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
        public void SwitchCamerasBack()
        {
            camera2.enabled = false;
            camera1.enabled = true;
        }
}
