using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour
{
    public void moveScene(string pageName)
    {
        SceneManager.LoadScene(pageName);
        SfxManager.sfx.Audio.PlayOneShot(SfxManager.sfx.Click);
    }
    public void QuitGame()
    {
        SfxManager.sfx.Audio.PlayOneShot(SfxManager.sfx.Click);
        Application.Quit();
    }
}
