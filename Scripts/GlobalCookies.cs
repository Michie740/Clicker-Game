using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCookies : MonoBehaviour
{
    public static int HeartCount;

    public GameObject HeartDisplay;

    public int InternalHeart;


    // Update is called once per frame
    void Update()
    {
        InternalHeart = HeartCount;
        HeartDisplay.GetComponent<Text>().text = "Hearts: " + InternalHeart;

    }
}
