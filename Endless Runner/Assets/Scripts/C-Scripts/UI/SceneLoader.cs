using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void ChangeSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void ChangeToNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void ChangeSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}
