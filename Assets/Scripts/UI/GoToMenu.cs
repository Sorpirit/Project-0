using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public void GoToMainMenu ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
        Debug.Log("going to main menu...");
        Time.timeScale = 1f;
    }
}
