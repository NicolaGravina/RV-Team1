using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CameraTargetEye : MonoBehaviour
{
    void Start()
    {
        Camera.main.stereoTargetEye = StereoTargetEyeMask.Both;
    }
}