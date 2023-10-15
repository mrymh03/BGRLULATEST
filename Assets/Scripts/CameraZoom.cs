using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main;
        cam.fieldOfView = 10;
    }

    // Update is called once per frame
    void Update()
    {
        cam.fieldOfView = 5;
    }
}
