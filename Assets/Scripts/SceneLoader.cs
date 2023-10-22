using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
///  Handles scene management for buttons S
/// </summary>
public class SceneLoader : MonoBehaviour
{
    /// <summary>
    /// Loads scene named in Button menu
    /// </summary>
    /// <param name="sceneName"></param>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
