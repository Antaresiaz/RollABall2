using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform ballPosition;
    public Vector3 offset;
    
    void LateUpdate()
    {
        transform.position = ballPosition.position + offset;

    }
}
