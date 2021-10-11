using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureScreen : MonoBehaviour
{
    public void Capture()
    {
        ScreenCapture.CaptureScreenshot("ARDrawing_Capture");
    }
}
