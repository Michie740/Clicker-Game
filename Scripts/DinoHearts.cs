using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;


public class DinoHearts : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource playSound;

    public string randomDinoQuote;
    public static int DinoHeartCount = 0;


    string[] dinoQuotes = new string[4] { "Dino, who's baby are you? That's right, Kelly's!",
        "I love you like no otter~", "rawr", "This is true love~" };

    public void ClickTheButton()
    {
        GlobalCookies.HeartCount += 1;
        DinoHeartCount += 1;

        randomDinoQuote = dinoQuotes[UnityEngine.Random.Range(0, dinoQuotes.Length)];
        if (DinoHeartCount != 0 && DinoHeartCount % 50 == 0)
        {
            playSound.Play();
            statusBox.GetComponent<Text>().text = randomDinoQuote + " Dino received 50 more hearts!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else if (DinoHeartCount != 0 && DinoHeartCount % 10 == 0)
        {
            statusBox.GetComponent<Text>().text = randomDinoQuote + " Dino received 10 more hearts!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }


    }


}
