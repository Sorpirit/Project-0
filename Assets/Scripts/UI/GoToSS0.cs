using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSS0 : MonoBehaviour
{
    public void GoToStarSystem0()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
        Debug.Log("going to StarSystem O...");
    }
}
