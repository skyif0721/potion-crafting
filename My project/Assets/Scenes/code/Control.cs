using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("working 0w0");
    }
}
