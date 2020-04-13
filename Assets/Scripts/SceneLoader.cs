using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string currentSceneName;
    public string sceneName = default;

    void Awake()
    {
        Debug.Log($"Scene Loaded Awake : {currentSceneName}");
    }

    void Start()
    {
        Debug.Log($"Scene Loaded Start : {currentSceneName}");
    }

    public void Load()
    {
        SceneManager.LoadScene($"Scene{sceneName}");
    }
}
