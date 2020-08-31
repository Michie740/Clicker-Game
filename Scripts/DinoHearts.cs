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

    public GameObject dinoPinkOne;
    public GameObject dinoPinkTwo;
    public GameObject dinoBlueOne;
    public GameObject dinoBlueTwo;
    public GameObject dinoDino;
    public GameObject dinoOtter;
    public GameObject dinoBigHeart;
    public int randomNumber;

    public string randomDinoQuote;
    public static int DinoHeartCount = 0;


    string[] dinoQuotes = new string[4] { "Dino, who's baby are you? That's right, Kelly's!",
        "I love you like no otter~", "rawr", "This is true love~" };

    public void ClickTheButton()
    {
        GlobalCookies.HeartCount += 1;
        DinoHeartCount += 1;

        randomNumber = UnityEngine.Random.Range(1, 3);
        randomDinoQuote = dinoQuotes[UnityEngine.Random.Range(0, dinoQuotes.Length)];
        if (DinoHeartCount != 0 && DinoHeartCount % 50 == 0)
        {
            playSound.Play();
            statusBox.GetComponent<Text>().text = randomDinoQuote + " Dino received 50 more hearts!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");

            if (randomNumber == 1)
            {
                dinoBigHeart.GetComponent<Animation>().Play("DinoBigHearts");
            }
            else
            {
                dinoOtter.GetComponent<Animation>().Play("DinoOtter");
            }
        }
        else if (DinoHeartCount != 0 && DinoHeartCount % 10 == 0)
        {
            statusBox.GetComponent<Text>().text = randomDinoQuote + " Dino received 10 more hearts!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }


    }

    public void showThemHearts()
    {
        randomNumber = UnityEngine.Random.Range(1, 6);
        if (DinoHeartCount != 0 && DinoHeartCount % 50 != 0)
        {
            if (randomNumber == 1)
            {
                dinoPinkOne.GetComponent<Animation>().Play("DPinkOne");
            }
            else if (randomNumber == 2)
            {
                dinoPinkTwo.GetComponent<Animation>().Play("DPinkTwo");
            }
            else if (randomNumber == 3)
            {
                dinoBlueOne.GetComponent<Animation>().Play("DBlueOne");
            }
            else if (randomNumber == 4)
            {
                dinoBlueTwo.GetComponent<Animation>().Play("DBlueTwo");
            }
            else
            {
                dinoDino.GetComponent<Animation>().Play("DinoDino");
            }
        }
    }
}
