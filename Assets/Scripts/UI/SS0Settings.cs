using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS0Settings : MonoBehaviour
{
    GameObject Settings;
    GameObject General;
    GameObject Language;
    GameObject Control;
    GameObject Sound;
    GameObject MyProfile;
    GameObject Graphix;
    GameObject Social;
    GameObject Help;
    public GameObject PauseUI;
    public GameObject ResumeButtonUI;
    public GameObject JustSettingsUI;

    void Start()
    {
        Settings = GameObject.FindGameObjectWithTag("MainSettingsPanel");
        General = GameObject.FindGameObjectWithTag("GeneralPanel");
        Language = GameObject.FindGameObjectWithTag("LanguagePanel");
        Control = GameObject.FindGameObjectWithTag("ControlPanel");
        Sound = GameObject.FindGameObjectWithTag("SoundPanel");
        MyProfile = GameObject.FindGameObjectWithTag("MyProfilePanel");
        Graphix = GameObject.FindGameObjectWithTag("GraphixPanel");
        Social = GameObject.FindGameObjectWithTag("SocialPanel");
        Help = GameObject.FindGameObjectWithTag("HelpPanel");

        Settings.SetActive(true);
        General.SetActive(false);
        Language.SetActive(false);
        Control.SetActive(false);
        Sound.SetActive(false);
        MyProfile.SetActive(false);
        Graphix.SetActive(false);
        Social.SetActive(false);
        Help.SetActive(false);
    }
    public void GoToSettings()
    {
        Debug.Log("going to main settings...");
        General.SetActive(false);
        Language.SetActive(false);
        Control.SetActive(false);
        Sound.SetActive(false);
        MyProfile.SetActive(false);
        Graphix.SetActive(false);
        Social.SetActive(false);
        Help.SetActive(false);
        Settings.SetActive(true);

    }
    public void GoToGeneralSettings()
    {
        Debug.Log("going to general settings...");
        General.SetActive(true);
        Settings.SetActive(false);
    }
    public void GoToLanguageSettings()
    {
        Debug.Log("going to language settings...");
        Language.SetActive(true);
        Settings.SetActive(false);
    }
    public void GoToControlSettings()
    {
        Debug.Log("going to control settings...");
        Control.SetActive(true);
        Settings.SetActive(false);
    }
    public void GoToSoundSettings()
    {
        Debug.Log("going to Sound settings...");
        Sound.SetActive(true);
        Settings.SetActive(false);
    }
    public void GoToMyProfileSettings()
    {
        Debug.Log("going to My Profile settings...");
        MyProfile.SetActive(true);
        Settings.SetActive(false);
    }
    public void GoToGraphixSettings()
    {
        Debug.Log("going to graphix settings...");
        Graphix.SetActive(true);
        Settings.SetActive(false);
    }
    public void GoToSocialSettings()
    {
        Debug.Log("going to social settings...");
        Social.SetActive(true);
        Settings.SetActive(false);
    }
    public void GoToHelpSettings()
    {
        Debug.Log("going to Help settings...");
        Help.SetActive(true);
        Settings.SetActive(false);
    }
    public void GoToPause()
    {
        Debug.Log("going to pause menu...");
        JustSettingsUI.SetActive(false);
        PauseUI.SetActive(true);
        ResumeButtonUI.SetActive(true);
    }
}
