using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEnabler : MonoBehaviour
{
    public Camera camera;

    void EnableCamera()
    {
        camera.enabled = true;
    }
    void DiableCamera()
    {
        camera.enabled = false;
    }
}
