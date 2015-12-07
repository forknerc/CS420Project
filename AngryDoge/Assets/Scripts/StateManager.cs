using UnityEngine;
using System.Collections.Generic;

public class StateManager : MonoBehaviour 
{
    public List<GameObject> levels;
    private GameObject currentLevel;

    public void exitApplication()
    {
        /*if(Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }*/

        Application.Quit();
    }

    public void levelSelection(int selected)
    {
        if(currentLevel != null)
        {
            Destroy(currentLevel);
        }

        currentLevel = Instantiate(levels[selected], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        currentLevel.gameObject.SetActive(true);
    }
}
