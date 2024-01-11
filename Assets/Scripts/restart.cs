using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RestartScene()
    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
