using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PausePanelUI;
    public GameObject PauseButtonUI;
    public GameObject ResumeButtonUI;
    public GameObject JustSettingsUI;
    public GameObject ResumeButtonToUI;
    private void Start()
    {
        PausePanelUI.SetActive(false);
        ResumeButtonUI.SetActive(false);
        JustSettingsUI.SetActive(false);
        ResumeButtonToUI.SetActive(false);
        PauseButtonUI.SetActive(true);
}
    public void OpenPause()
    {
        Debug.Log("pause");
        PausePanelUI.SetActive(true);
        PauseButtonUI.SetActive(false);
        ResumeButtonUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ClosePause()
    {
        Debug.Log("Resume");
        PausePanelUI.SetActive(false);
        PauseButtonUI.SetActive(true);
        ResumeButtonUI.SetActive(false);
        JustSettingsUI.SetActive(false);
        Time.timeScale = 1f;

    }
    public void OpenSettings()
    {
        Debug.Log("going to settings");
        PausePanelUI.SetActive(false);
        PauseButtonUI.SetActive(false);
        ResumeButtonUI.SetActive(false);
        JustSettingsUI.SetActive(true);
        ResumeButtonToUI.SetActive(false);
    }
}
