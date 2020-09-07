using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Letsgo : MonoBehaviour
{
    // Start is called before the first frame update
    public void doExitGame()
    {
        Application.Quit();
        UnityEngine.Debug.Log("Game is Exiting");
    }
}
