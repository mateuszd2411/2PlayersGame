using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string level1;
    public string level2;

    // Start is called before the first frame update
    public void StartLevel1()
    {
        SceneManager.LoadScene(level1);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(level2);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
