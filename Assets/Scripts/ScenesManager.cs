using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScenesManager : MonoBehaviour 
{
	public static ScenesManager instance;

    private bool fading = false;

	void Awake()
	{
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
	}

    void OnGUI()
    {
        if (fading)
        {

        }
    }
}
