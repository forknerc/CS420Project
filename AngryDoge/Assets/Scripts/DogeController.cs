using UnityEngine;
using System.Collections;

public class DogeController : MonoBehaviour 
{
    public int TimeUntilDespawn = 10;

	// Use this for initialization
	void Start () 
	{
        StartCoroutine(DogeTimeout());
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

    private IEnumerator DogeTimeout()
    {
        yield return new WaitForSeconds(TimeUntilDespawn);

        Destroy(gameObject);
    }
}
