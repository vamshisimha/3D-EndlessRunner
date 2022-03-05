using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void restartbutton()
    {
        SceneManager.LoadScene(1);

    }
    public void exitbutton()
    {
        Application.Quit();
    }

}
