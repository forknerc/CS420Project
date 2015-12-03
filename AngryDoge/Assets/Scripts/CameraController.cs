using UnityEngine;
using System.Collections.Generic;

public class CameraController : MonoBehaviour
{
    public List<Camera> GameCameras;

    public void ChangeCamera(int camNum)
    {
        foreach(var cam in GameCameras)
        {
            cam.gameObject.SetActive(false);
        }

        GameCameras[camNum].gameObject.SetActive(true);
    }
}
