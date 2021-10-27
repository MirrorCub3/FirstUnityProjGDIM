using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToScene : MonoBehaviour
{
    public void GoTo(string goTo)
    {
        if (goTo.Equals("Quit"))
        {
            Application.Quit();
        }
        SceneManager.LoadScene(goTo);
    }
}
