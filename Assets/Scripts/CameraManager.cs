using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform tr;
    public float cameraSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(tr.position.x, tr.position.y, -13), cameraSpeed);
    }
}
