using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader: MonoBehaviour
{
    public int savedHearts;
    public int savedValue;

    void Start()
    {
        if (MainMenuOptions.isLoading == true)
        {
            savedHearts = PlayerPrefs.GetInt("SavedHearts");
            GlobalCookies.HeartCount = savedHearts;

            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;
        }
    }


}
