using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public AudioSource backSound;

    public void GoBack()
    {
        backSound.Play();
        SceneManager.LoadScene(0);
    }
}
