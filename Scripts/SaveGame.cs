using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveGame : MonoBehaviour
{
    public int saveGameHeart;
    public static int saveValue = 10;
    public GameObject saveButton;
    public GameObject saveText;

    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost: " + saveValue + " Hearts";
        saveGameHeart = GlobalCookies.HeartCount;
        if (saveGameHeart >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            saveButton.GetComponent<Button>().interactable = false;
        }
    }

    public void SaveTheGame()
    {
        GlobalCookies.HeartCount -= saveValue;
        PlayerPrefs.SetInt("SavedHearts", GlobalCookies.HeartCount);
        saveValue *= 2;
        PlayerPrefs.SetInt("SaveValue", saveValue);

    }


}
