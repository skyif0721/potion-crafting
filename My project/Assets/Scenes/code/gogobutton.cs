using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gogobutton : MonoBehaviour
{
    public int sceneBuildIndex;
    public void GoToSceneTwo()
    {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
}
