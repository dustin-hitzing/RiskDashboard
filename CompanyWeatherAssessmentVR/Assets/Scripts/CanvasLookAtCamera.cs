using AT.XR.RiskManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasLookAtCamera : MonoBehaviour
{
    public Camera XRCamera;
    void Update()
    {
        transform.LookAt(XRCamera.transform);
        //var xrRotation = XRCamera.transform.rotation;
        //XRCamera.transform.Rotate(new Vector3(xrRotation.x, xrRotation.y, 180f));
    }
}
