using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;


public class HoshiHearts : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource playSound;

    public GameObject hoshiPinkHeartOne;
    public GameObject hoshiPinkHeartTwo;
    public GameObject hoshiBlueHeartOne;
    public GameObject hoshiBlueHeartTwo;
    public GameObject HSBH;

    public int randomNumber;

    public string randomHoshiQuote;
    public static int HoshiHeartCount = 0;

    string[] hoshiQuotes = new string[4] { "Very nice!",
        "My heart goes boom-boom.", "rawr", "This is true love~" };

    public void ClickTheButton()
    {
        GlobalCookies.HeartCount += 1;
        HoshiHeartCount += 1;

        randomHoshiQuote = hoshiQuotes[UnityEngine.Random.Range(0, hoshiQuotes.Length)];

        if (HoshiHeartCount != 0 && HoshiHeartCount % 50 == 0)
        {
            playSound.Play();
            statusBox.GetComponent<Text>().text = randomHoshiQuote + " Hoshi received 50 more hearts!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            HSBH.GetComponent<Animation>().Play("hoshiBigHearts");
        }

        else if (HoshiHeartCount != 0 && HoshiHeartCount % 10 == 0)
        {
 
            statusBox.GetComponent<Text>().text = randomHoshiQuote + " Hoshi received 10 more hearts!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }

    public void showThemHearts()
    {
        randomNumber = UnityEngine.Random.Range(1, 5);
        if (HoshiHeartCount != 0 && HoshiHeartCount % 50 != 0){
            if (randomNumber == 1)
            {
                hoshiPinkHeartOne.GetComponent<Animation>().Play("HoshiPinkHeartOne");
            }
            else if (randomNumber == 2)
            {
                hoshiPinkHeartTwo.GetComponent<Animation>().Play("HoshiPH2");
            }
            else if (randomNumber == 3)
            {
                hoshiBlueHeartOne.GetComponent<Animation>().Play("HoshiBlueHeartOne");
            }

            else
            {
                hoshiBlueHeartTwo.GetComponent<Animation>().Play("HoshiBH2");
            }
            
        }

    }

}
