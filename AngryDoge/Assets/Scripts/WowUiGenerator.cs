using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WowUiGenerator : MonoBehaviour
{
    public float SidePadding;

    public float TimeBetweenWows;

    public float WowDuration;

    public List<GameObject> Wows;

    private RectTransform canvasRectTransform;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GenerateWows();
        }
    }

    public void GenerateWows()
    {
        StopAllCoroutines();

        DisableAllWows();

        ShuffleWows();

        StartCoroutine(MakeWow());
    }

    private IEnumerator MakeWow()
    {
        foreach(var wow in Wows)
        {
            wow.SetActive(true);

            StartCoroutine(WowTimeout(wow));

            yield return new WaitForSeconds(TimeBetweenWows);
        }
        
    }

    private IEnumerator WowTimeout(GameObject wow)
    {
        yield return new WaitForSeconds(WowDuration);

        wow.SetActive(false);
    }

    private void DisableAllWows()
    {
        foreach(var wow in Wows)
        {
            wow.SetActive(false);
        }
    }

    private void ShuffleWows()
    {
        for(int i = 0; i < 10; i++)
        {
            int rand = Random.Range(0, Wows.Count);
            var temp = Wows[rand];
            Wows.RemoveAt(rand);
            Wows.Add(temp);
        }
    }
}
