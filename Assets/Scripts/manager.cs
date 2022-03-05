using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update

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
