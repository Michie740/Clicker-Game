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

    public string randomHanQuote;
    public static int HanHeartCount = 0;

    string[] hanQuotes = new string[4] { "Han", "han", "HAN", "haN" };

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
        }
        else if (HanHeartCount != 0 && HanHeartCount % 10 == 0)
        {
            statusBox.GetComponent<Text>().text = randomHanQuote + " Han received 10 more hearts!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }


}
