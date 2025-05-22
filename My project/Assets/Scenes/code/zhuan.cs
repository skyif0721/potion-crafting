using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class zhuan : MonoBehaviour
{
    public float countTime = 0f;


    void Update()
    {
        CountTime();

    }

    void CountTime()
    {
        countTime += Time.deltaTime;
        if (countTime > 40.0f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
