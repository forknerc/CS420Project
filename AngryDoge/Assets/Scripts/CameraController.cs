using UnityEngine;
using System.Collections.Generic;

public class CameraController : MonoBehaviour
{
    public List<Camera> GameCameras;

    public int StartCameraIndex;
    public int NumGameCameras;

    private int currentCameraIndex;

    public void SwitchGameCamera(bool leftClicked)
    {
        if(leftClicked)
        {
            if(currentCameraIndex == 0)
            {
                currentCameraIndex = NumGameCameras - 1;
            }
            else
            {
                currentCameraIndex--;
            }
        }
        else
        {
            if(currentCameraIndex == NumGameCameras - 1)
            {
                currentCameraIndex = 0;
            }
            else
            {
                currentCameraIndex++;
            }
        }

        ChangeCamera(currentCameraIndex);
    }

    public void ChangeCamera(int camNum)
    {
        currentCameraIndex = camNum;

        foreach(var cam in GameCameras)
        {
            cam.gameObject.SetActive(false);
        }

        GameCameras[camNum].gameObject.SetActive(true);
    }

    protected void Start()
    {
        ChangeCamera(StartCameraIndex);
    }

}
