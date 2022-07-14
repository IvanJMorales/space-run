using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Google.XR.Cardboard;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Api.MinTriggerHeldPressedTime = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Api.IsTriggerPressed == true)
        {
            LoadEarthLevel();
        }

        if(Api.IsTriggerHeldPressed == true)
        {
            LoadMarsLevel();
        }
    }

    public void LoadEarthLevel()
    {
        SceneManager.LoadScene("EarthLevel");
    }

    public void LoadMarsLevel()
    {
        SceneManager.LoadScene("MarsLevel");
    }
}
