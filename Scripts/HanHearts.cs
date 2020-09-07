using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;

public class HanHearts : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource playSound;
    public GameObject hanBlueOne;
    public GameObject hanBlueTwo;
    public GameObject hanPinkOne;
    public GameObject hanSparkle;
    public GameObject hanBigHeart;
    public int randomNumber;


    public string randomHanQuote;
    public static int HanHeartCount = 0;

    string[] hanQuotes = new string[4] { "WOW~", "DOUBLE KNOT ON MY YEEZYS!", "Chef's Kiss!", "<3 <3 <3" };

    public void ClickTheButton()
    {
        GlobalCookies.HeartCount += 1;
        HanHeartCount += 1;

        randomHanQuote = hanQuotes[UnityEngine.Random.Range(0, hanQuotes.Length)];
        if (HanHeartCount != 0 && HanHeartCount % 50 == 0)
        {
            playSound.Play();
            statusBox.GetComponent<Text>().text = randomHanQuote + " Han received 50 more hearts!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            hanBigHeart.GetComponent<Animation>().Play("HanBigHeart");
        }
        else if (HanHeartCount != 0 && HanHeartCount % 10 == 0)
        {
            statusBox.GetComponent<Text>().text = randomHanQuote + " Han received 10 more hearts!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }

    public void showThemHearts()
    {
        randomNumber = UnityEngine.Random.Range(1, 5);
        if (HanHeartCount != 0 && HanHeartCount % 50 != 0)
        {
            if (randomNumber == 1)
            {
                hanBlueOne.GetComponent<Animation>().Play("HanBlueOne");
            }
            else if (randomNumber == 2)
            {
                hanBlueTwo.GetComponent<Animation>().Play("HanBlueTwo");
            }
            else if (randomNumber == 3)
            {
                hanPinkOne.GetComponent<Animation>().Play("HanPink");
            }

            else
            {
                hanSparkle.GetComponent<Animation>().Play("HanSparkle");
            }

        }

    }
}
