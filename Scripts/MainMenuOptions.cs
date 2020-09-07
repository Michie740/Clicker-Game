using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    public static bool isLoading = false;
    public AudioSource clickSound;

    public void NewGame()
    {
        clickSound.Play();
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        clickSound.Play();
        isLoading = true;
        SceneManager.LoadScene(2);
    }
}
