using UnityEngine;
using System.Collections.Generic;

public class UIController : MonoBehaviour
{
    public List<GameObject> GameUIs;

    public void ChangeUI(int UINum)
    {
        foreach (var cam in GameUIs)
        {
            cam.gameObject.SetActive(false);
        }

        GameUIs[UINum].gameObject.SetActive(true);
    }
}
